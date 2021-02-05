using System;
using System.Text.Json;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public class JsonSerializerDeserializeOptionsProvider : IJsonSerializerDeserializeOptionsProvider
    {
        public JsonSerializerOptions Options { get; init; }

        public JsonSerializerDeserializeOptionsProvider(JsonSerializerOptions options)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
        }
    }
}