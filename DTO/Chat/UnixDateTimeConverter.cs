using System;
using Newtonsoft.Json;

namespace gmc_api.DTO.Chat
{
    public class UnixDateTimeConverter : JsonConverter<DateTime?>
    {
        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(new DateTimeOffset(value.Value).ToUnixTimeMilliseconds());
            else
                writer.WriteNull();
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                var milliseconds = (long)reader.Value!;
                return DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).DateTime;
            }

            return null;
        }
    }
}