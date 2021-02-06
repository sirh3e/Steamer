using System;
using System.Text.Json;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public class SteamerSystemTextJsonSerializerOptionsProvider : ISteamerSystemTextJsonSerializerOptionsProvider
    {
        public SteamerSystemTextJsonSerializerOptionsProvider(JsonSerializerOptions options)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public JsonSerializerOptions Options { get; init; }
    }
}