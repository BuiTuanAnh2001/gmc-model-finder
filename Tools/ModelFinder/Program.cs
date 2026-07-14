using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

var port = ResolvePort();
var bindAddress = Environment.GetEnvironmentVariable("RENDER") is not null ||
    !string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("PORT"))
    ? IPAddress.Any
    : IPAddress.Loopback;
var displayHost = Equals(bindAddress, IPAddress.Any) ? "0.0.0.0" : "127.0.0.1";
var url = $"http://{displayHost}:{port}/";

var rootState = new RootState(ResolveRepositoryRoot(args));
using var listener = new TcpListener(bindAddress, port);
listener.Start();

Console.WriteLine($"GMC Model Finder: {url}");
Console.WriteLine($"Scanning root: {rootState.Value}");
_ = Task.Run(() =>
{
    var stopwatch = Stopwatch.StartNew();
    var catalog = rootState.GetCatalog();
    stopwatch.Stop();
    Console.WriteLine($"Indexed {catalog.Models.Count} models / {catalog.PropertyCount} properties in {stopwatch.ElapsedMilliseconds} ms");
});

while (true)
{
    var client = await listener.AcceptTcpClientAsync();
    _ = Task.Run(() => HandleClient(client, rootState));
}

static async Task HandleClient(TcpClient client, RootState rootState)
{
    await using var stream = client.GetStream();
    using var reader = new StreamReader(stream, Encoding.UTF8, leaveOpen: true);

    try
    {
        var requestLine = await reader.ReadLineAsync();
        if (string.IsNullOrWhiteSpace(requestLine))
        {
            return;
        }

        var parts = requestLine.Split(' ', 3);
        if (parts.Length < 2)
        {
            await WriteJson(stream, new { error = "Bad request." }, 400);
            return;
        }

        var method = parts[0];
        var path = parts[1].Split('?', 2)[0];
        var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        string? line;
        while (!string.IsNullOrEmpty(line = await reader.ReadLineAsync()))
        {
            var separator = line.IndexOf(':');
            if (separator > 0)
            {
                headers[line[..separator].Trim()] = line[(separator + 1)..].Trim();
            }
        }

        if (method == "GET" && path == "/")
        {
            await WriteText(stream, HtmlAssets.PageHtml, "text/html; charset=utf-8");
            return;
        }

        if (method == "GET" && path == "/assets/gmc-logo.png")
        {
            var logoPath = Path.Combine(AppContext.BaseDirectory, "assets", "gmc-logo.png");
            if (!File.Exists(logoPath))
            {
                logoPath = Path.Combine(Directory.GetCurrentDirectory(), "Tools", "ModelFinder", "assets", "gmc-logo.png");
            }

            if (!File.Exists(logoPath))
            {
                await WriteJson(stream, new { error = "Logo file not found." }, 404);
                return;
            }

            await WriteFile(stream, logoPath, "image/png");
            return;
        }

        if (method == "GET" && path == "/api/models")
        {
            var repositoryRoot = rootState.Value;
            var catalog = rootState.GetCatalog();
            await WriteJson(stream, new
            {
                root = repositoryRoot,
                modelCount = catalog.Models.Count,
                propertyCount = catalog.PropertyCount
            });
            return;
        }

        if (method == "POST" && path == "/api/root")
        {
            var rootRequest = JsonSerializer.Deserialize<RootRequest>(await ReadBody(reader, headers), AppJson.Options);
            var nextRoot = Path.GetFullPath(rootRequest?.RootPath ?? "");
            if (!Directory.Exists(nextRoot))
            {
                await WriteJson(stream, new { error = "Folder does not exist." }, 400);
                return;
            }

            if (!Directory.Exists(Path.Combine(nextRoot, "Entities")) && !Directory.Exists(Path.Combine(nextRoot, "DTO")))
            {
                await WriteJson(stream, new { error = "Folder must contain Entities or DTO." }, 400);
                return;
            }

            var catalog = rootState.SetRoot(nextRoot);
            await WriteJson(stream, new
            {
                root = nextRoot,
                modelCount = catalog.Models.Count,
                propertyCount = catalog.PropertyCount
            });
            return;
        }

        if (method == "POST" && path == "/api/pick-root")
        {
            var pickedRoot = FolderPicker.Pick();
            if (string.IsNullOrWhiteSpace(pickedRoot))
            {
                await WriteJson(stream, new { error = "No folder selected or folder picker is not available." }, 400);
                return;
            }

            if (!Directory.Exists(Path.Combine(pickedRoot, "Entities")) && !Directory.Exists(Path.Combine(pickedRoot, "DTO")))
            {
                await WriteJson(stream, new { error = "Selected folder must contain Entities or DTO." }, 400);
                return;
            }

            var catalog = rootState.SetRoot(pickedRoot);
            await WriteJson(stream, new
            {
                root = pickedRoot,
                modelCount = catalog.Models.Count,
                propertyCount = catalog.PropertyCount
            });
            return;
        }

        if (method == "POST" && path == "/api/search")
        {
            var requestStopwatch = Stopwatch.StartNew();
            var body = await ReadBody(reader, headers);
            var searchRequest = JsonSerializer.Deserialize<SearchRequest>(body, AppJson.Options);
            if (string.IsNullOrWhiteSpace(searchRequest?.Json))
            {
                await WriteJson(stream, new { error = "Paste JSON before searching." }, 400);
                return;
            }

            try
            {
                var jsonFields = JsonShapeReader.Read(searchRequest.Json);
                Console.WriteLine($"Search parsed {jsonFields.Count} JSON fields in {requestStopwatch.ElapsedMilliseconds} ms");
                if (jsonFields.Count == 0)
                {
                    await WriteJson(stream, new { error = "No object fields found in the JSON." }, 400);
                    return;
                }

                var repositoryRoot = rootState.Value;
                var stopwatch = Stopwatch.StartNew();
                var catalog = rootState.GetCatalog();
                Console.WriteLine($"Search got catalog in {requestStopwatch.ElapsedMilliseconds} ms");
                var results = ModelMatcher.Score(catalog, jsonFields, Math.Clamp(searchRequest.Limit ?? 20, 1, 100));
                stopwatch.Stop();
                Console.WriteLine($"Search scored {results.Count} results in {stopwatch.ElapsedMilliseconds} ms");

                await WriteJson(stream, new
                {
                    root = repositoryRoot,
                    jsonFields,
                    modelCount = catalog.Models.Count,
                    elapsedMs = stopwatch.ElapsedMilliseconds,
                    results = results.Select(result => new
                    {
                        model = new
                        {
                            result.Model.Name,
                            result.Model.FilePath,
                            result.Model.RelativePath
                        },
                        result.Score,
                        result.MatchedFields,
                        result.JsonFieldCount,
                        result.PropertyCount,
                        result.Matches,
                        result.MissingFields
                    })
                });
                Console.WriteLine($"Search response written in {requestStopwatch.ElapsedMilliseconds} ms");
            }
            catch (JsonException ex)
            {
                await WriteJson(stream, new { error = $"Invalid JSON: {ex.Message}" }, 400);
            }

            return;
        }

        await WriteJson(stream, new { error = "Not found." }, 404);
    }
    catch (Exception ex)
    {
        await WriteJson(stream, new { error = ex.Message }, 500);
    }
}

static int ResolvePort()
{
    var rawPort = Environment.GetEnvironmentVariable("PORT");
    return int.TryParse(rawPort, out var port) && port > 0
        ? port
        : 5087;
}

static async Task<string> ReadBody(StreamReader reader, Dictionary<string, string> headers)
{
    var contentLength = headers.TryGetValue("Content-Length", out var rawLength) && int.TryParse(rawLength, out var length)
        ? length
        : 0;
    var builder = new StringBuilder(contentLength);
    var bytesRead = 0;
    var buffer = new char[1];
    while (bytesRead < contentLength)
    {
        var chunk = await reader.ReadAsync(buffer, 0, 1);
        if (chunk == 0)
        {
            break;
        }

        builder.Append(buffer[0]);
        bytesRead += Encoding.UTF8.GetByteCount(buffer.AsSpan(0, 1));
    }

    return builder.ToString();
}

static string ResolveRepositoryRoot(string[] args)
{
    var explicitRoot = ReadArgument(args, "--root") ?? ReadArgument(args, "-r");
    if (!string.IsNullOrWhiteSpace(explicitRoot))
    {
        return Path.GetFullPath(explicitRoot);
    }

    var environmentRoot = Environment.GetEnvironmentVariable("MODEL_FINDER_ROOT");
    if (!string.IsNullOrWhiteSpace(environmentRoot))
    {
        return Path.GetFullPath(environmentRoot);
    }

    return FindRepositoryRoot(Directory.GetCurrentDirectory());
}

static string? ReadArgument(string[] args, string name)
{
    for (var index = 0; index < args.Length; index++)
    {
        if (string.Equals(args[index], name, StringComparison.OrdinalIgnoreCase) && index + 1 < args.Length)
        {
            return args[index + 1];
        }

        if (args[index].StartsWith(name + "=", StringComparison.OrdinalIgnoreCase))
        {
            return args[index][(name.Length + 1)..];
        }
    }

    return null;
}

static string FindRepositoryRoot(string startDirectory)
{
    var current = new DirectoryInfo(startDirectory);
    while (current is not null)
    {
        if (Directory.Exists(Path.Combine(current.FullName, "Entities")))
        {
            return current.FullName;
        }

        current = current.Parent;
    }

    return startDirectory;
}

static async Task WriteJson(Stream stream, object payload, int statusCode = 200)
{
    var json = JsonSerializer.Serialize(payload, AppJson.Options);
    await WriteText(stream, json, "application/json; charset=utf-8", statusCode);
}

static async Task WriteText(Stream stream, string content, string contentType, int statusCode = 200)
{
    var bytes = Encoding.UTF8.GetBytes(content);
    var reason = statusCode switch
    {
        200 => "OK",
        400 => "Bad Request",
        404 => "Not Found",
        500 => "Internal Server Error",
        _ => "OK"
    };
    var header = Encoding.ASCII.GetBytes(
        $"HTTP/1.1 {statusCode} {reason}\r\nContent-Type: {contentType}\r\nContent-Length: {bytes.Length}\r\nConnection: close\r\n\r\n");
    await stream.WriteAsync(header);
    await stream.WriteAsync(bytes);
}

static async Task WriteFile(Stream stream, string filePath, string contentType, int statusCode = 200)
{
    var bytes = await File.ReadAllBytesAsync(filePath);
    var reason = statusCode == 200 ? "OK" : "Not Found";
    var header = Encoding.ASCII.GetBytes(
        $"HTTP/1.1 {statusCode} {reason}\r\nContent-Type: {contentType}\r\nContent-Length: {bytes.Length}\r\nCache-Control: no-store\r\nConnection: close\r\n\r\n");
    await stream.WriteAsync(header);
    await stream.WriteAsync(bytes);
}

static class AppJson
{
    public static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = false
    };
}

sealed class RootState(string value)
{
    private readonly object _gate = new();
    private string _value = value;
    private ModelCatalogSnapshot? _catalog;

    public string Value
    {
        get
        {
            lock (_gate)
            {
                return _value;
            }
        }
        set
        {
            lock (_gate)
            {
                _value = value;
                _catalog = null;
            }
        }
    }

    public ModelCatalogSnapshot GetCatalog()
    {
        lock (_gate)
        {
            _catalog ??= ModelCatalog.Load(_value);
            return _catalog;
        }
    }

    public ModelCatalogSnapshot SetRoot(string value)
    {
        lock (_gate)
        {
            _value = value;
            _catalog = ModelCatalog.Load(_value);
            return _catalog;
        }
    }
}

static class FolderPicker
{
    public static string? Pick()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return RunPicker("osascript", "-e", "POSIX path of (choose folder with prompt \"Select the model source folder\")");
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            const string script = "Add-Type -AssemblyName System.Windows.Forms; $d = New-Object System.Windows.Forms.FolderBrowserDialog; $d.Description = 'Select the model source folder'; if ($d.ShowDialog() -eq 'OK') { $d.SelectedPath }";
            return RunPicker("powershell", "-NoProfile", "-STA", "-Command", script)
                ?? RunPicker("pwsh", "-NoProfile", "-Command", script);
        }

        return RunPicker("zenity", "--file-selection", "--directory", "--title=Select the model source folder")
            ?? RunPicker("kdialog", "--getexistingdirectory");
    }

    private static string? RunPicker(string fileName, params string[] arguments)
    {
        try
        {
            var startInfo = new ProcessStartInfo(fileName)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            foreach (var argument in arguments)
            {
                startInfo.ArgumentList.Add(argument);
            }

            using var process = Process.Start(startInfo);
            if (process is null)
            {
                return null;
            }

            var output = process.StandardOutput.ReadToEnd().Trim();
            process.WaitForExit();
            return process.ExitCode == 0 && !string.IsNullOrWhiteSpace(output)
                ? Path.GetFullPath(output)
                : null;
        }
        catch
        {
            return null;
        }
    }
}

record SearchRequest(string Json, int? Limit);

record RootRequest(string RootPath);

record JsonField(string Path, string Name, string Kind, string Sample);

record ModelInfo(
    string Name,
    string FilePath,
    string RelativePath,
    IReadOnlyList<ModelProperty> Properties,
    [property: JsonIgnore] IReadOnlyDictionary<string, ModelProperty> PropertiesByName);

record ModelProperty(
    string Name,
    string Type,
    IReadOnlyList<string> JsonNames,
    [property: JsonIgnore] string NormalizedName,
    [property: JsonIgnore] IReadOnlySet<string> SearchNames,
    [property: JsonIgnore] IReadOnlySet<string> Tokens);

static class ModelPropertyFactory
{
    public static ModelProperty Create(string name, string type, IReadOnlyList<string> jsonNames)
    {
        var normalizedName = NameTools.Normalize(name);
        var searchNames = jsonNames
            .Select(NameTools.Normalize)
            .Append(normalizedName)
            .Where(value => value.Length > 0)
            .ToHashSet(StringComparer.Ordinal);
        var tokens = jsonNames
            .Append(name)
            .SelectMany(NameTools.Tokenize)
            .ToHashSet(StringComparer.Ordinal);

        return new ModelProperty(name, type, jsonNames, normalizedName, searchNames, tokens);
    }
}

record FieldMatch(JsonField JsonField, ModelProperty? Property, double NameScore, bool TypeMatched)
{
    public bool Matched => Property is not null;
}

record MatchResult(
    ModelInfo Model,
    double Score,
    int MatchedFields,
    int JsonFieldCount,
    int PropertyCount,
    IReadOnlyList<FieldMatch> Matches,
    IReadOnlyList<JsonField> MissingFields);

record IndexedProperty(ModelInfo Model, ModelProperty Property);

static class ModelCatalog
{
    private static readonly Regex ClassRegex = new(@"\bpublic\s+(?:partial\s+)?class\s+([A-Za-z_][A-Za-z0-9_]*)", RegexOptions.Compiled);
    private static readonly Regex PropertyRegex = new(
        @"(?<attrs>(?:\s*\[[^\]]+\]\s*)*)\bpublic\s+(?!class\b|interface\b|enum\b|static\b)(?<type>[A-Za-z_][A-Za-z0-9_<>,\.\?\[\]\s]*)\s+(?<name>[A-Za-z_][A-Za-z0-9_]*)\s*\{",
        RegexOptions.Compiled);
    private static readonly Regex JsonAttributeRegex = new(
        @"\[(?:[A-Za-z_][A-Za-z0-9_]*\.)?(?:JsonProperty|JsonPropertyName)\b(?<args>[^\]]*)\]",
        RegexOptions.Compiled);
    private static readonly Regex JsonNameLiteralRegex = new(
        @"(?:PropertyName\s*=\s*)?""(?<name>(?:\\.|[^""\\])*)""",
        RegexOptions.Compiled);

    public static ModelCatalogSnapshot Load(string root)
    {
        var searchRoots = new[] { "Entities", "DTO" }
            .Select(path => Path.Combine(root, path))
            .Where(Directory.Exists)
            .ToList();

        var models = new List<ModelInfo>();
        foreach (var searchRoot in searchRoots)
        {
            foreach (var file in Directory.EnumerateFiles(searchRoot, "*.cs", SearchOption.AllDirectories))
            {
                var text = ReadSourceText(file);
                if (string.IsNullOrWhiteSpace(text))
                {
                    continue;
                }

                var classes = ClassRegex.Matches(text).Select(match => match.Groups[1].Value).Distinct().ToList();
                if (classes.Count == 0)
                {
                    continue;
                }

                var properties = PropertyRegex.Matches(text)
                    .Select(match => ModelPropertyFactory.Create(
                        match.Groups["name"].Value.Trim(),
                        Regex.Replace(match.Groups["type"].Value, @"\s+", ""),
                        ReadJsonNames(match.Groups["attrs"].Value)))
                    .Where(property => !string.Equals(property.Name, "Item", StringComparison.Ordinal))
                    .DistinctBy(property => property.Name)
                    .ToList();

                if (properties.Count == 0)
                {
                    continue;
                }

                var modelPropertiesByName = properties
                    .SelectMany(property => property.SearchNames.Select(searchName => new { searchName, property }))
                    .GroupBy(item => item.searchName, StringComparer.Ordinal)
                    .ToDictionary(group => group.Key, group => group.First().property, StringComparer.Ordinal);
                var relativePath = Path.GetRelativePath(root, file);
                foreach (var className in classes)
                {
                    models.Add(new ModelInfo(className, file, relativePath, properties, modelPropertiesByName));
                }
            }
        }

        var modelProperties = models
            .SelectMany(model => model.Properties.Select(property => new IndexedProperty(model, property)))
            .ToList();
        var indexedProperties = models
            .SelectMany(model => model.Properties.SelectMany(property => property.SearchNames.Select(_ => new IndexedProperty(model, property))))
            .DistinctBy(item => (item.Model, item.Property.Name))
            .ToList();

        var propertiesByName = indexedProperties
            .SelectMany(item => item.Property.SearchNames.Select(searchName => new { searchName, item }))
            .GroupBy(item => item.searchName, StringComparer.Ordinal)
            .ToDictionary(group => group.Key, group => (IReadOnlyList<IndexedProperty>)group.Select(item => item.item).ToList(), StringComparer.Ordinal);

        var propertiesByToken = indexedProperties
            .SelectMany(item => item.Property.Tokens.Select(token => new { token, item }))
            .GroupBy(item => item.token, StringComparer.Ordinal)
            .ToDictionary(group => group.Key, group => (IReadOnlyList<IndexedProperty>)group.Select(item => item.item).ToList(), StringComparer.Ordinal);

        var propertiesByPrefix = indexedProperties
            .SelectMany(item => item.Property.SearchNames.Where(searchName => searchName.Length >= 6).Select(searchName => new { searchName, item }))
            .GroupBy(item => NameTools.PrefixKey(item.searchName), StringComparer.Ordinal)
            .ToDictionary(group => group.Key, group => (IReadOnlyList<IndexedProperty>)group.Select(item => item.item).Distinct().ToList(), StringComparer.Ordinal);

        return new ModelCatalogSnapshot(models, modelProperties.Count, propertiesByName, propertiesByToken, propertiesByPrefix);
    }

    private static IReadOnlyList<string> ReadJsonNames(string attributes)
    {
        if (string.IsNullOrWhiteSpace(attributes))
        {
            return [];
        }

        return JsonAttributeRegex.Matches(attributes)
            .Select(match => JsonNameLiteralRegex.Match(match.Groups["args"].Value))
            .Where(match => match.Success)
            .Select(match => Regex.Unescape(match.Groups["name"].Value))
            .Where(name => !string.IsNullOrWhiteSpace(name))
            .Distinct(StringComparer.Ordinal)
            .ToList();
    }

    private static string ReadSourceText(string file)
    {
        using var stream = File.OpenRead(file);
        using var reader = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
        return reader.ReadToEnd();
    }
}

record ModelCatalogSnapshot(
    IReadOnlyList<ModelInfo> Models,
    int PropertyCount,
    IReadOnlyDictionary<string, IReadOnlyList<IndexedProperty>> PropertiesByName,
    IReadOnlyDictionary<string, IReadOnlyList<IndexedProperty>> PropertiesByToken,
    IReadOnlyDictionary<string, IReadOnlyList<IndexedProperty>> PropertiesByPrefix);

static class JsonShapeReader
{
    public static IReadOnlyList<JsonField> Read(string json)
    {
        using var document = JsonDocument.Parse(json, new JsonDocumentOptions
        {
            AllowTrailingCommas = true,
            CommentHandling = JsonCommentHandling.Skip
        });

        var fields = new Dictionary<string, JsonField>(StringComparer.OrdinalIgnoreCase);
        Visit(document.RootElement, "", fields);
        return fields.Values
            .OrderBy(field => field.Path.Count(ch => ch == '.'))
            .ThenBy(field => field.Path)
            .ToList();
    }

    private static void Visit(JsonElement element, string path, Dictionary<string, JsonField> fields)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                foreach (var property in element.EnumerateObject())
                {
                    var childPath = string.IsNullOrWhiteSpace(path) ? property.Name : $"{path}.{property.Name}";
                    if (property.Value.ValueKind is JsonValueKind.Object or JsonValueKind.Array)
                    {
                        Visit(property.Value, childPath, fields);
                    }
                    else
                    {
                        fields[childPath] = new JsonField(childPath, property.Name, InferKind(property.Value), Sample(property.Value));
                    }
                }
                break;

            case JsonValueKind.Array:
                foreach (var item in element.EnumerateArray().Take(20))
                {
                    Visit(item, path, fields);
                }
                break;
        }
    }

    private static string InferKind(JsonElement element)
    {
        return element.ValueKind switch
        {
            JsonValueKind.String when LooksLikeDate(element.GetString()) => "date",
            JsonValueKind.String => "string",
            JsonValueKind.Number when element.TryGetInt64(out _) => "integer",
            JsonValueKind.Number => "decimal",
            JsonValueKind.True or JsonValueKind.False => "boolean",
            JsonValueKind.Null => "null",
            _ => "unknown"
        };
    }

    private static bool LooksLikeDate(string? value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
        {
            return false;
        }

        return DateTimeOffset.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
    }

    private static string Sample(JsonElement element)
    {
        var value = element.ValueKind == JsonValueKind.String ? element.GetString() ?? "" : element.ToString();
        return value.Length <= 80 ? value : value[..77] + "...";
    }
}

static class ModelMatcher
{
    public static IReadOnlyList<MatchResult> Score(ModelCatalogSnapshot catalog, IReadOnlyList<JsonField> jsonFields, int limit)
    {
        var fields = jsonFields
            .Select(field => new FieldShape(field, NameTools.Normalize(field.Name), NameTools.Tokenize(field.Name)))
            .ToList();
        var exactHitCounts = CountExactHits(catalog, fields);
        var exactThreshold = Math.Min(8, Math.Max(3, fields.Count / 10));
        if (exactHitCounts.Count > 0 && exactHitCounts.Values.Max() >= exactThreshold)
        {
            return exactHitCounts
                .OrderByDescending(item => item.Value)
                .Where(item => item.Value >= exactThreshold)
                .Take(Math.Max(12, limit * 2))
                .Select(item => ScoreSingleModel(item.Key, jsonFields, fields))
                .Where(result => result.MatchedFields > 0)
                .OrderByDescending(result => result.Score)
                .ThenByDescending(result => result.MatchedFields)
                .ThenBy(result => result.Model.Name)
                .Take(limit)
                .ToList();
        }

        var matchesByModel = new Dictionary<ModelInfo, List<FieldMatch>>();

        foreach (var field in fields)
        {
            foreach (var match in FindCandidateMatches(catalog, field))
            {
                if (!matchesByModel.TryGetValue(match.Model, out var matches))
                {
                    matches = new List<FieldMatch>();
                    matchesByModel[match.Model] = matches;
                }

                var existingIndex = matches.FindIndex(item => item.JsonField.Path == field.Field.Path);
                if (existingIndex < 0)
                {
                    matches.Add(match.Match);
                }
                else
                {
                    var existing = matches[existingIndex];
                    if (match.Match.NameScore > existing.NameScore ||
                        (Math.Abs(match.Match.NameScore - existing.NameScore) < 0.001 && match.Match.TypeMatched && !existing.TypeMatched))
                    {
                        matches[existingIndex] = match.Match;
                    }
                }
            }
        }

        return matchesByModel
            .Select(item => BuildResult(item.Key, jsonFields, item.Value))
            .Where(result => result.MatchedFields > 0)
            .OrderByDescending(result => result.Score)
            .ThenByDescending(result => result.MatchedFields)
            .ThenBy(result => result.Model.Name)
            .Take(limit)
            .ToList();
    }

    private static Dictionary<ModelInfo, int> CountExactHits(ModelCatalogSnapshot catalog, IReadOnlyList<FieldShape> fields)
    {
        var counts = new Dictionary<ModelInfo, int>();
        foreach (var field in fields)
        {
            if (!catalog.PropertiesByName.TryGetValue(field.NormalizedName, out var exactMatches))
            {
                continue;
            }

            foreach (var model in exactMatches.Select(match => match.Model).Distinct())
            {
                counts.TryGetValue(model, out var count);
                counts[model] = count + 1;
            }
        }

        return counts;
    }

    private static MatchResult ScoreSingleModel(ModelInfo model, IReadOnlyList<JsonField> jsonFields, IReadOnlyList<FieldShape> fields)
    {
        var matches = new List<FieldMatch>();
        foreach (var field in fields)
        {
            var candidate = FindBestPropertyInModel(model, field);
            matches.Add(candidate is null
                ? new FieldMatch(field.Field, null, 0, false)
                : new FieldMatch(
                    field.Field,
                    candidate.Value.Property,
                    candidate.Value.NameScore,
                    TypeMatches(field.Field.Kind, candidate.Value.Property.Type)));
        }

        return BuildResult(model, jsonFields, matches.Where(match => match.Matched).ToList());
    }

    private static (ModelProperty Property, double NameScore)? FindBestPropertyInModel(ModelInfo model, FieldShape field)
    {
        (ModelProperty Property, double NameScore)? best = null;
        if (model.PropertiesByName.TryGetValue(field.NormalizedName, out var exactProperty))
        {
            return (exactProperty, 1);
        }

        foreach (var property in model.Properties)
        {
            if (!property.SearchNames.Any(searchName => NameTools.PrefixKey(searchName) == NameTools.PrefixKey(field.NormalizedName)))
            {
                continue;
            }

            var score = NameScore(field.NormalizedName, field.Tokens, property);
            if (score < 0.55)
            {
                continue;
            }

            if (best is null || score > best.Value.NameScore)
            {
                best = (property, score);
            }
        }

        if (best is not null)
        {
            return best;
        }

        foreach (var property in model.Properties)
        {
            if (!field.Tokens.Any(token => !NameTools.IsBroadToken(token) && property.Tokens.Contains(token)))
            {
                continue;
            }

            var score = NameScore(field.NormalizedName, field.Tokens, property);
            if (score < 0.55)
            {
                continue;
            }

            if (best is null || score > best.Value.NameScore)
            {
                best = (property, score);
            }
        }

        return best;
    }

    private static IEnumerable<(ModelInfo Model, FieldMatch Match)> FindCandidateMatches(ModelCatalogSnapshot catalog, FieldShape field)
    {
        var candidates = new Dictionary<(ModelInfo Model, string PropertyName), IndexedProperty>();
        if (catalog.PropertiesByName.TryGetValue(field.NormalizedName, out var exactMatches))
        {
            AddCandidates(candidates, exactMatches);
        }

        if (candidates.Count == 0)
        {
            var prefixKey = NameTools.PrefixKey(field.NormalizedName);
            if (catalog.PropertiesByPrefix.TryGetValue(prefixKey, out var prefixMatches))
            {
                AddCandidates(candidates, prefixMatches);
            }
        }

        if (candidates.Count == 0)
        {
            foreach (var token in field.Tokens)
            {
                if (NameTools.IsBroadToken(token))
                {
                    continue;
                }

                if (catalog.PropertiesByToken.TryGetValue(token, out var tokenMatches) && tokenMatches.Count <= 200)
                {
                    AddCandidates(candidates, tokenMatches);
                }
            }
        }

        foreach (var candidate in candidates.Values)
        {
            var nameScore = NameScore(field.NormalizedName, field.Tokens, candidate.Property);
            if (nameScore < 0.55)
            {
                continue;
            }

            yield return (candidate.Model, new FieldMatch(
                field.Field,
                candidate.Property,
                nameScore,
                TypeMatches(field.Field.Kind, candidate.Property.Type)));
        }
    }

    private static void AddCandidates(Dictionary<(ModelInfo Model, string PropertyName), IndexedProperty> candidates, IReadOnlyList<IndexedProperty> items)
    {
        foreach (var item in items)
        {
            candidates.TryAdd((item.Model, item.Property.Name), item);
        }
    }

    private static MatchResult BuildResult(ModelInfo model, IReadOnlyList<JsonField> jsonFields, IReadOnlyList<FieldMatch> matchedFields)
    {
        var matchesByPath = matchedFields.ToDictionary(match => match.JsonField.Path, StringComparer.OrdinalIgnoreCase);
        var matches = jsonFields
            .Select(field => matchesByPath.TryGetValue(field.Path, out var match)
                ? match
                : new FieldMatch(field, null, 0, false))
            .ToList();

        var matched = matches.Count(match => match.Matched);
        var namePoints = matches.Sum(match => match.Matched ? match.NameScore : 0);
        var typePoints = matches.Sum(match => match.TypeMatched ? 0.15 : 0);
        var coverage = jsonFields.Count == 0 ? 0 : (namePoints + typePoints) / jsonFields.Count;
        var extraPenalty = Math.Min(0.18, Math.Max(0, model.Properties.Count - matched) * 0.0015);
        var score = Math.Clamp((coverage - extraPenalty) * 100, 0, 100);

        return new MatchResult(
            model,
            Math.Round(score, 1),
            matched,
            jsonFields.Count,
            model.Properties.Count,
            matches.OrderByDescending(match => match.NameScore).ToList(),
            matches.Where(match => !match.Matched).Select(match => match.JsonField).ToList());
    }

    private static bool TypeMatches(string jsonKind, string csharpType)
    {
        var type = csharpType.Replace("Nullable<", "", StringComparison.OrdinalIgnoreCase)
            .Replace(">", "", StringComparison.Ordinal)
            .Replace("?", "", StringComparison.Ordinal)
            .ToLowerInvariant();

        return jsonKind switch
        {
            "string" => type is "string",
            "date" => type.Contains("datetime") || type.Contains("dateonly") || type is "string",
            "integer" => type is "int" or "long" or "short" or "byte" or "decimal" or "double" or "float",
            "decimal" => type is "decimal" or "double" or "float",
            "boolean" => type is "bool" or "boolean",
            "null" => true,
            _ => false
        };
    }

    private static double NameScore(string normalizedJsonName, IReadOnlySet<string> jsonTokens, ModelProperty property)
    {
        if (normalizedJsonName.Length == 0)
        {
            return 0;
        }

        var best = 0.0;
        foreach (var right in property.SearchNames)
        {
            if (right.Length == 0)
            {
                continue;
            }

            if (normalizedJsonName == right)
            {
                return 1;
            }

            if (right.EndsWith(normalizedJsonName, StringComparison.Ordinal) || normalizedJsonName.EndsWith(right, StringComparison.Ordinal))
            {
                best = Math.Max(best, 0.88);
            }

            var prefixScore = NameTools.CommonPrefixScore(normalizedJsonName, right);
            if (prefixScore >= 0.55)
            {
                best = Math.Max(best, Math.Min(0.86, prefixScore));
            }
        }

        var tokenScore = NameTools.TokenOverlap(jsonTokens, property.Tokens);
        if (tokenScore >= 0.55)
        {
            best = Math.Max(best, tokenScore);
        }

        return best;
    }
}

record FieldShape(JsonField Field, string NormalizedName, IReadOnlySet<string> Tokens);

static class NameTools
{
    public static string Normalize(string value)
    {
        var builder = new StringBuilder(value.Length);
        foreach (var ch in value)
        {
            if (char.IsLetterOrDigit(ch))
            {
                builder.Append(char.ToLowerInvariant(ch));
            }
        }

        return builder.ToString();
    }

    public static IReadOnlySet<string> Tokenize(string value)
    {
        var spaced = Regex.Replace(value, "([a-z0-9])([A-Z])", "$1 $2");
        return Regex.Split(spaced, @"[^A-Za-z0-9]+")
            .Where(token => token.Length > 1)
            .Select(token => token.ToLowerInvariant())
            .ToHashSet(StringComparer.Ordinal);
    }

    public static double TokenOverlap(IReadOnlySet<string> left, IReadOnlySet<string> right)
    {
        if (left.Count == 0 || right.Count == 0)
        {
            return 0;
        }

        var intersection = left.Count(right.Contains);
        return intersection / (double)Math.Max(left.Count, right.Count);
    }

    public static double CommonPrefixScore(string left, string right)
    {
        var length = Math.Min(left.Length, right.Length);
        var common = 0;
        while (common < length && left[common] == right[common])
        {
            common++;
        }

        return common / (double)Math.Max(left.Length, right.Length);
    }

    public static string PrefixKey(string normalizedName)
    {
        if (normalizedName.Length <= 8)
        {
            return normalizedName;
        }

        return normalizedName[..8];
    }

    public static bool IsBroadToken(string token)
    {
        return token.Length <= 2 ||
            token is "id" or "no" or "fk" or "aa" or "ic" or "ar" or "ap" or "pp" or "gl" or "br" or "ge" or "hr" or "wo" or
            "date" or "name" or "desc" or "status" or "combo" or "transfer";
    }

}

static class HtmlAssets
{
    public const string PageHtml = """
<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <title>GMC Model Finder</title>
  <style>
    :root {
      color-scheme: light;
      --navy: #0d3267;
      --navy-deep: #061e43;
      --orange: #ff9412;
      --orange-deep: #df7400;
      --ink: #152033;
      --muted: #667085;
      --paper: #f4f6f9;
      --panel: #ffffff;
      --soft: #f8fafc;
      --editor: #eef2f7;
      --line: #d6dce7;
      --warn: #c33b2d;
      --ok: #15804d;
      --shadow: 0 1px 2px rgba(16, 24, 40, .06);
    }

    * { box-sizing: border-box; }

    body {
      margin: 0;
      min-height: 100vh;
      font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", sans-serif;
      background: var(--paper);
      color: var(--ink);
      padding: 0;
      overflow: hidden;
    }

    button, textarea, input {
      font: inherit;
    }

    .shell {
      width: 100%;
      height: 100vh;
      min-height: 100vh;
      margin: 0;
      padding: 0 24px 16px;
      background: var(--panel);
      border: 0;
      border-radius: 0;
      box-shadow: none;
      display: flex;
      flex-direction: column;
    }

    .topbar {
      display: flex;
      justify-content: space-between;
      align-items: center;
      gap: 20px;
      border-bottom: 1px solid var(--line);
      padding: 18px 0 14px;
      margin-bottom: 14px;
      background: transparent;
    }

    .brand {
      display: flex;
      align-items: center;
      gap: 14px;
      min-width: 0;
    }

    .brand-mark {
      width: 52px;
      max-width: 52px;
      height: auto;
      flex: 0 0 auto;
      display: block;
      object-fit: contain;
    }

    .fallback-logo {
      display: none;
    }

    .brand-title {
      min-width: 0;
      padding-right: 22px;
      border-right: 1px solid var(--line);
    }

    h1 {
      margin: 0 0 2px;
      font-size: 27px;
      line-height: 1.05;
      letter-spacing: 0;
      color: #0b1f3c;
      font-weight: 800;
      white-space: nowrap;
    }

    .subtitle {
      color: var(--muted);
      font-size: 13px;
      font-weight: 650;
    }

    .meta {
      color: #374151;
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      font-weight: 700;
      line-height: 1;
      border: 1px solid var(--line);
      background: var(--soft);
      border-radius: 999px;
      padding: 8px 13px;
      white-space: nowrap;
      box-shadow: inset 0 1px 0 rgba(255,255,255,.9);
    }

    .workspace {
      display: grid;
      grid-template-columns: minmax(320px, 400px) minmax(0, 1fr);
      gap: 14px;
      align-items: stretch;
      flex: 1;
      min-height: 0;
      overflow: hidden;
    }

    .source-panel {
      display: grid;
      grid-template-columns: auto minmax(0, 1fr) auto auto;
      gap: 12px;
      align-items: center;
      padding: 15px;
      margin-bottom: 14px;
      background: #fbfcfe;
    }

    .source-input {
      min-height: 40px;
      width: 100%;
      border: 1px solid var(--line);
      border-radius: 6px;
      padding: 9px 12px 9px 38px;
      outline: none;
      color: var(--ink);
      background:
        url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='19' height='19' viewBox='0 0 24 24' fill='none' stroke='%23667085' stroke-width='2' stroke-linecap='round' stroke-linejoin='round'%3E%3Cpath d='M4 20h16a2 2 0 0 0 2-2V8a2 2 0 0 0-2-2h-7.9a2 2 0 0 1-1.69-.9L9.6 3.9A2 2 0 0 0 7.93 3H4a2 2 0 0 0-2 2v13a2 2 0 0 0 2 2Z'/%3E%3C/svg%3E") 13px center / 18px 18px no-repeat,
        #f7f9fc;
      font-size: 14px;
    }

    .source-label {
      color: #374151;
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      font-weight: 700;
      text-transform: uppercase;
      white-space: nowrap;
    }

    .panel {
      background: var(--panel);
      border: 1px solid var(--line);
      border-radius: 8px;
      box-shadow: none;
    }

    .input-panel {
      overflow: hidden;
      display: flex;
      flex-direction: column;
      height: 100%;
      min-height: 0;
      min-width: 0;
    }

    .panel-head {
      display: flex;
      align-items: center;
      justify-content: space-between;
      gap: 12px;
      padding: 12px 14px;
      border-bottom: 1px solid var(--line);
      background: var(--soft);
    }

    .label {
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      text-transform: uppercase;
      letter-spacing: .08em;
      color: var(--muted);
      font-weight: 700;
    }

    .threshold {
      display: flex;
      align-items: center;
      gap: 10px;
      color: var(--muted);
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      font-weight: 700;
    }

    #limit {
      width: 58px;
      min-height: 32px;
      border: 1px solid var(--line);
      border-radius: 4px;
      color: var(--ink);
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      font-weight: 700;
      text-align: center;
      background: white;
      outline: none;
    }

    .editor-wrap {
      display: grid;
      grid-template-columns: 38px minmax(0, 1fr);
      flex: 1;
      min-height: 0;
      background: var(--editor);
    }

    .line-numbers {
      padding-top: 17px;
      border-right: 1px solid var(--line);
      color: #9aa4b2;
      background: #edf1f6;
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 13px;
      line-height: 1.65;
      text-align: right;
      user-select: none;
      padding-right: 9px;
    }

    textarea {
      width: 100%;
      height: 100%;
      min-height: 0;
      border: 0;
      resize: none;
      padding: 16px;
      outline: none;
      background: #f0f4f9;
      color: #111827;
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 13px;
      line-height: 1.65;
    }

    .actions {
      display: flex;
      gap: 10px;
      padding: 14px;
      border-top: 1px solid var(--line);
      align-items: center;
      background: #f8fafc;
    }

    .button {
      border: 1px solid var(--orange-deep);
      background: var(--orange);
      color: #272015;
      border-radius: 4px;
      padding: 9px 16px;
      cursor: pointer;
      min-height: 40px;
      font-size: 14px;
      font-weight: 650;
      display: inline-flex;
      align-items: center;
      justify-content: center;
      gap: 8px;
      white-space: nowrap;
    }

    .button.secondary {
      background: white;
      color: var(--navy);
      border-color: var(--line);
    }

    .button.danger {
      background: white;
      border-color: #f2b8b3;
      color: var(--warn);
    }

    .button:disabled {
      cursor: wait;
      opacity: .62;
    }

    .status {
      color: var(--muted);
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      margin-left: auto;
    }

    .results {
      display: grid;
      gap: 12px;
      align-content: start;
      grid-auto-rows: max-content;
      padding: 15px;
      border: 1px solid var(--line);
      border-radius: 8px;
      background: var(--panel);
      height: 100%;
      min-height: 0;
      min-width: 0;
      overflow: auto;
    }

    .empty {
      min-height: 100%;
      display: grid;
      place-items: center;
      align-content: center;
      gap: 10px;
      padding: 44px;
      color: var(--muted);
      text-align: center;
      border: 1px dashed var(--line);
      border-radius: 8px;
      background: #fbfcfe;
    }

    .empty-icon {
      width: 62px;
      height: 62px;
      border-radius: 10px;
      display: grid;
      place-items: center;
      color: #9db7da;
      background: var(--navy);
      margin-bottom: 6px;
    }

    .empty h2 {
      margin: 0;
      font-size: 20px;
      line-height: 1.2;
      color: #252b36;
    }

    .empty p {
      width: min(470px, 100%);
      margin: 0;
      font-size: 14px;
      line-height: 1.45;
    }

    .result {
      display: grid;
      grid-template-columns: 86px minmax(0, 1fr);
      gap: 14px;
      padding: 14px;
      border: 1px solid var(--line);
      border-radius: 8px;
      background: #ffffff;
    }

    .score {
      display: grid;
      place-items: center;
      aspect-ratio: 1;
      border-radius: 6px;
      border: 1px solid rgba(255, 147, 20, .44);
      color: var(--navy);
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 22px;
      font-weight: 700;
      background: #fff4e4;
    }

    .app-footer {
      display: flex;
      justify-content: space-between;
      gap: 18px;
      align-items: center;
      padding-top: 14px;
      color: var(--navy-deep);
      font-size: 12px;
      font-weight: 800;
    }

    .footer-links {
      display: flex;
      gap: 28px;
      align-items: center;
      font-weight: 500;
    }

    .footer-links a {
      color: #3f4653;
      text-decoration: underline;
      text-underline-offset: 2px;
    }

    .name {
      margin: 1px 0 4px;
      font-size: 22px;
      line-height: 1.1;
      overflow-wrap: anywhere;
    }

    .path {
      color: var(--muted);
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      overflow-wrap: anywhere;
      margin-bottom: 10px;
    }

    .badges {
      display: flex;
      flex-wrap: wrap;
      gap: 8px;
      margin-bottom: 12px;
    }

    .badge {
      border: 1px solid var(--line);
      border-radius: 999px;
      padding: 4px 8px;
      color: var(--muted);
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
      background: rgba(255,255,255,.42);
    }

    .json-alias {
      margin-top: 3px;
      color: var(--muted);
      font-size: 11px;
      line-height: 1.35;
    }

    details {
      border-top: 1px solid var(--line);
      padding-top: 10px;
    }

    summary {
      cursor: pointer;
      color: var(--navy);
      font-weight: 700;
    }

    table {
      width: 100%;
      border-collapse: collapse;
      margin-top: 10px;
      font-family: ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
      font-size: 12px;
    }

    th, td {
      padding: 7px 6px;
      border-bottom: 1px solid rgba(217,208,192,.7);
      vertical-align: top;
      text-align: left;
    }

    th { color: var(--muted); font-weight: 600; }
    .ok { color: var(--ok); }
    .warn { color: var(--warn); }

    @media (max-width: 920px) {
      .workspace { grid-template-columns: 1fr; }
      .source-panel { grid-template-columns: 1fr; }
      body { overflow: auto; }
      .shell { height: auto; min-height: 100vh; padding: 0 14px 14px; }
      .workspace { overflow: visible; }
      .input-panel, .results { height: auto; }
      textarea { min-height: 360px; resize: vertical; }
      .topbar { align-items: start; flex-direction: column; }
      .meta { text-align: left; }
      .brand { align-items: flex-start; flex-direction: column; }
      .brand-title { border-right: 0; padding-right: 0; }
      h1 { white-space: normal; }
      .actions { flex-wrap: wrap; }
      .status { flex-basis: 100%; margin-left: 0; }
      .app-footer { align-items: flex-start; flex-direction: column; }
      .footer-links { flex-wrap: wrap; gap: 14px; }
    }
  </style>
</head>
<body>
  <main class="shell">
    <header class="topbar">
      <div class="brand">
        <img class="brand-mark" src="/assets/gmc-logo.png" alt="GMC Expert ERP Smart Solution" onerror="this.style.display='none';this.nextElementSibling.style.display='block';" />
        <svg class="brand-mark fallback-logo" viewBox="0 0 560 160" role="img" aria-label="GMC Expert ERP Smart Solution">
          <rect width="560" height="160" fill="white"/>
          <g fill="none" stroke="#ff9314" stroke-width="8" stroke-linecap="square" stroke-linejoin="miter" transform="translate(18 22)">
            <path d="M52 12h52v18H84v22h38v40H84v22h30"/>
            <path d="M36 30H16v48h20M16 78v48h58v-20H52V88h-34"/>
            <path d="M70 0v24M116 18h22v44h-20M138 62h-22v32h28"/>
            <path d="M68 48H42v34h38V68H58"/>
            <path d="M96 104h42v22H96v22H58"/>
            <path d="M36 116v32M18 18v18M132 0v16M152 48v22M150 100v20"/>
          </g>
          <text x="188" y="82" fill="#112d63" font-family="Arial, Helvetica, sans-serif" font-size="82" font-weight="800" letter-spacing="2">GMC</text>
          <text x="193" y="122" fill="#112d63" font-family="Arial, Helvetica, sans-serif" font-size="20" font-weight="700" letter-spacing=".8">EXPERT ERP-SMART SOLUTION</text>
        </svg>
        <div class="brand-title">
          <h1>Model Finder</h1>
          <div class="subtitle">Find C# models from API JSON responses</div>
        </div>
      </div>
      <div class="meta" id="meta">Scanning model catalog...</div>
    </header>
    
    <section class="workspace">
      <section class="panel input-panel">
        <div class="panel-head">
          <div class="label">API JSON response</div>
          <label class="threshold">Threshold <input id="limit" type="number" min="1" max="100" value="5" aria-label="Result limit" /></label>
        </div>
        <div class="editor-wrap">
          <div class="line-numbers" aria-hidden="true">1<br>2<br>3<br>4<br>5<br>6<br>7<br>8</div>
          <textarea id="json" spellcheck="false" placeholder='Paste JSON here, for example:&#10;
    {
    "viewProductionOrdrID":1,
    "viewProductionOrdrDate":"2026-07-01",
    "viewProductionOrdrQty":10
    }'></textarea>
        </div>
        <div class="actions">
          <button class="button" id="search">
            <svg width="15" height="15" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.2" stroke-linecap="round" stroke-linejoin="round" aria-hidden="true"><circle cx="11" cy="11" r="8"/><path d="m21 21-4.3-4.3"/></svg>
            Find Models
          </button>
          <button class="button danger" id="cancelSearch" disabled>Cancel</button>
          <button class="button secondary" id="sample">Sample</button>
          <span class="status" id="status"></span>
        </div>
      </section>

      <section class="results" id="results">
        <div class="empty">
          <div class="empty-icon">
            <svg width="26" height="26" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.1" stroke-linecap="round" stroke-linejoin="round" aria-hidden="true"><path d="m10 8-4 4 4 4"/><path d="m14 8 4 4-4 4"/><rect x="3" y="4" width="18" height="16" rx="2"/></svg>
          </div>
          <h2>Awaiting JSON Input</h2>
          <p>Paste JSON to find matching classes in Entities and DTO. The system will analyze the payload and suggest C# models that fit.</p>
        </div>
      </section>
    </section>

    <footer class="app-footer">
      <div>© 2024 GMC Expert ERP-Smart Solution</div>
      <nav class="footer-links" aria-label="Footer links">
        <a href="#" aria-label="Documentation">Documentation</a>
        <a href="#" aria-label="Support">Support</a>
        <a href="#" aria-label="Release Notes">Release Notes</a>
      </nav>
    </footer>
  </main>

  <script>
    const jsonInput = document.getElementById('json');
    const searchButton = document.getElementById('search');
    const sampleButton = document.getElementById('sample');
    const statusEl = document.getElementById('status');
    const resultsEl = document.getElementById('results');
    const metaEl = document.getElementById('meta');
    const limitInput = document.getElementById('limit');
    const rootPathInput = document.getElementById('rootPath');
    const chooseRootButton = document.getElementById('chooseRoot');
    const applyRootButton = document.getElementById('applyRoot');
    const cancelSearchButton = document.getElementById('cancelSearch');
    let activeSearch = null;

    loadCatalog();

    sampleButton.addEventListener('click', () => {
      jsonInput.value = JSON.stringify([{
        viewProductionOrdrID: 1,
        fK_PPProductionOrdrID: 12045,
        viewProductionOrdrDate: '2026-07-01T08:30:00',
        viewProductionOrdrQty: 25.5,
        viewProductionOrdrLotNo: 'LOT-2026-07',
        viewProductionOrdrDesc: 'Production order sample',
        viewProductionOrdrFirstPhaseCfgCheck: true
      }], null, 2);
      jsonInput.focus();
    });

    searchButton.addEventListener('click', search);
    cancelSearchButton.addEventListener('click', cancelSearch);
    chooseRootButton?.addEventListener('click', chooseRoot);
    applyRootButton?.addEventListener('click', applyRoot);
    jsonInput.addEventListener('keydown', event => {
      if ((event.metaKey || event.ctrlKey) && event.key === 'Enter') search();
    });

    async function loadCatalog() {
      try {
        const response = await fetch('/api/models');
        const data = await response.json();
        if (!response.ok) throw new Error(data.error || 'Catalog unavailable');
        updateCatalog(data);
      } catch {
        metaEl.textContent = 'Catalog unavailable';
      }
    }

    async function chooseRoot() {
      await updateRoot('/api/pick-root', null, 'Opening folder picker...');
    }

    async function applyRoot() {
      await updateRoot('/api/root', { rootPath: rootPathInput.value }, 'Applying source folder...');
    }

    async function updateRoot(url, body, message) {
      statusEl.textContent = message;
      if (chooseRootButton) chooseRootButton.disabled = true;
      if (applyRootButton) applyRootButton.disabled = true;
      try {
        const response = await fetch(url, {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: body ? JSON.stringify(body) : '{}'
        });
        const payload = await response.json();
        if (!response.ok) throw new Error(payload.error || 'Cannot update source folder');
        updateCatalog(payload);
        statusEl.textContent = 'Source folder updated';
      } catch (error) {
        statusEl.textContent = '';
        resultsEl.innerHTML = `<div class="empty warn">${escapeHtml(error.message)}</div>`;
      } finally {
        if (chooseRootButton) chooseRootButton.disabled = false;
        if (applyRootButton) applyRootButton.disabled = false;
      }
    }

    function updateCatalog(data) {
      if (rootPathInput) rootPathInput.value = data.root || '';
      metaEl.textContent = `${data.modelCount} models / ${data.propertyCount} properties`;
    }

    async function search() {
      if (activeSearch) activeSearch.abort();
      activeSearch = new AbortController();
      statusEl.textContent = 'Searching...';
      searchButton.disabled = true;
      cancelSearchButton.disabled = false;
      try {
        const response = await fetch('/api/search', {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify({ json: jsonInput.value, limit: Number(limitInput.value || 20) }),
          signal: activeSearch.signal
        });
        const payload = await response.json();
        if (!response.ok) throw new Error(payload.error || 'Search failed');
        render(payload);
        statusEl.textContent = `${payload.jsonFields.length} JSON fields / ${payload.elapsedMs ?? 0} ms`;
      } catch (error) {
        if (error.name === 'AbortError') {
          statusEl.textContent = 'Search canceled';
        } else {
          resultsEl.innerHTML = `<div class="empty warn">${escapeHtml(error.message)}</div>`;
          statusEl.textContent = '';
        }
      } finally {
        activeSearch = null;
        searchButton.disabled = false;
        cancelSearchButton.disabled = true;
      }
    }

    function cancelSearch() {
      if (activeSearch) activeSearch.abort();
    }

    function render(payload) {
      if (!payload.results.length) {
        resultsEl.innerHTML = '<div class="empty">No matching model found.</div>';
        return;
      }

      resultsEl.innerHTML = payload.results.map((result, index) => `
        <article class="result">
          <div class="score">${Math.round(result.score)}%</div>
          <div>
            <h2 class="name">${escapeHtml(result.model.name)}</h2>
            <div class="path">${escapeHtml(result.model.relativePath)}</div>
            <div class="badges">
              <span class="badge">${result.matchedFields}/${result.jsonFieldCount} fields</span>
              <span class="badge">${result.propertyCount} properties</span>
              <span class="badge">${result.missingFields.length} missing</span>
            </div>
            <details>
              <summary>Matched fields</summary>
              <table>
                <thead>
                  <tr>
                    <th>JSON</th>
                    <th>Kind</th>
                    <th>C# property</th>
                    <th>Type</th>
                    <th>Name</th>
                  </tr>
                </thead>
                <tbody>
                  ${result.matches.map(match => `
                    <tr>
                      <td>${escapeHtml(match.jsonField.path)}</td>
                      <td>${escapeHtml(match.jsonField.kind)}</td>
                      <td class="${match.matched ? 'ok' : 'warn'}">
                        ${escapeHtml(match.property?.name || 'missing')}
                        ${match.property?.jsonNames?.length ? `<div class="json-alias">JSON: ${escapeHtml(match.property.jsonNames.join(', '))}</div>` : ''}
                      </td>
                      <td>${escapeHtml(match.property?.type || '')}</td>
                      <td>${Math.round(match.nameScore * 100)}%</td>
                    </tr>
                  `).join('')}
                </tbody>
              </table>
            </details>
          </div>
        </article>
      `).join('');
    }

    function escapeHtml(value) {
      return String(value)
        .replaceAll('&', '&amp;')
        .replaceAll('<', '&lt;')
        .replaceAll('>', '&gt;')
        .replaceAll('"', '&quot;')
        .replaceAll("'", '&#039;');
    }
  </script>
</body>
</html>
""";
}
