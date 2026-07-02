# GMC Model Finder

Local web tool for finding C# models that match an API JSON response.

## Run

From the repository root:

```bash
dotnet run --project Tools/ModelFinder
```

Open the URL printed by `dotnet run`, usually:

```text
http://localhost:5087
```

Paste an API JSON response and click **Find Models**.

## Publish And Deploy

Build a Release publish folder:

```bash
dotnet publish Tools/ModelFinder/ModelFinder.csproj -c Release -o Tools/ModelFinder/publish
```

Run from the publish folder:

```bash
cd Tools/ModelFinder/publish
./ModelFinder --root /path/to/gmc-api-model
```

Then open:

```text
http://127.0.0.1:5087/
```

This publish output is framework-dependent, so the target machine needs the matching .NET runtime installed.

## Deploy To Render

This repository includes:

- `Dockerfile`
- `.dockerignore`
- `render.yaml`

Render deployment steps:

1. Push this repository to GitHub/GitLab.
2. In Render, create **New Web Service**.
3. Select the repository.
4. Choose **Docker** runtime.
5. Use the free plan if this is for demo/internal lightweight use.
6. Render sets `PORT`; the app automatically binds to it.
7. Set `MODEL_FINDER_ROOT=/app` if Render does not pick it from `render.yaml`.

The Docker image copies `Entities` and `DTO` into `/app`, so the deployed app searches the model source included in the repository at build time.

## Logo

To use the real company logo, place the PNG file here:

```text
Tools/ModelFinder/assets/gmc-logo.png
```

If that file does not exist, the app falls back to an inline GMC-style SVG logo.

## Model Source Path

If `Tools/ModelFinder` is inside the model repository, no path configuration is needed. The tool walks up from the current directory until it finds `Entities`.

In the web UI, use **Choose Folder** to select the model source folder. The selected folder must contain `Entities` or `DTO`.

The selected catalog is cached in memory, so searches after the first load are much faster. Use **Cancel Search** to abort a running search request from the browser.

If the model source is somewhere else, pass it explicitly:

```bash
dotnet run --project Tools/ModelFinder -- --root /path/to/gmc-api-model
```

After publishing/building, you can also pass the argument directly to the executable:

```bash
dotnet Tools/ModelFinder/bin/Debug/net10.0/ModelFinder.dll --root /path/to/gmc-api-model
```

Or set an environment variable:

```bash
MODEL_FINDER_ROOT=/path/to/gmc-api-model dotnet run --project Tools/ModelFinder
```

## What It Searches

By default the tool scans:

- `Entities`
- `DTO`

It reads `.cs` files directly, including generated UTF-16 model files.

## Matching Rules

The score is based on:

- property name match after normalizing casing and underscores
- partial/suffix name match for generated names
- inferred JSON type vs C# property type
- how many JSON fields are covered by the model
