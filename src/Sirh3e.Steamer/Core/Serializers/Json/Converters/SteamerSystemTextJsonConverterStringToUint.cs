using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Core.Serializers.Json.Converters
{
    public class SteamerSystemTextJsonConverterStringToUint : JsonConverter<uint>
    {
        public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => uint.Parse(reader.GetString() ?? "0");

        public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString());
    }
}