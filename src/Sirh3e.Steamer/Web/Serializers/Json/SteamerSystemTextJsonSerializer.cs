using System;
using System.Text.Json;
using Sirh3e.Steamer.Core.Serializer;
using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public class SteamerSystemTextJsonSerializer : ISteamerSerializer
    {
        public SteamerSystemTextJsonSerializer(
            ISteamerSystemTextJsonSerializerOptionsProvider serializerOptionsProvider) => SerializerOptionsProvider =
            serializerOptionsProvider ??
            throw new ArgumentNullException(nameof(serializerOptionsProvider));

        public ISteamerSystemTextJsonSerializerOptionsProvider SerializerOptionsProvider { get; set; }

        public T? Serialize<T>(ISteamerSerializerDataProvider dataProvider)
        {
            _ = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
            var data = dataProvider.GetData() ?? throw new ArgumentNullException(nameof(dataProvider.GetData));

            return JsonSerializer.Deserialize<T>(data, SerializerOptionsProvider.Options);
        }
    }
}