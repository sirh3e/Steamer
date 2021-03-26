using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Core.Serializers.Json.Converters
{
    public class SteamerSystemTextJsonConverterStringToUlong : JsonConverter<ulong>
    {
        public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            ulong.Parse(reader.GetString() ?? "0");

        public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());
    }
}