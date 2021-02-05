using System;
using System.Text.Json;
using Sirh3e.Steamer.Core.Serializer;
using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public class SystemTextJsonSerializer : ISteamerSerializer
    {
        public IJsonSerializerDeserializeOptionsProvider OptionsProvider { get; set; }

        public SystemTextJsonSerializer(IJsonSerializerDeserializeOptionsProvider optionsProvider)
        {
            OptionsProvider = optionsProvider ?? throw new ArgumentNullException(nameof(optionsProvider));
        }

        public T Serialize<T>(ISteamerSerializerDataProvider provider)
        {
            _ = provider ?? throw new ArgumentNullException(nameof(provider));
            var data = provider.GetData() ?? throw new ArgumentNullException(nameof(provider.GetData));

            return JsonSerializer.Deserialize<T>(data, OptionsProvider.Options);
        }
    }
}