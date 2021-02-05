using System;
using Sirh3e.Steamer.Core.Serializer;
using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public class NewtonsoftSerializer : ISteamerSerializer
    {
        private readonly Func<string, Type, object> SerializeFunc;

        public NewtonsoftSerializer(Func<string, Type, object> serializeFunc)
        {
            SerializeFunc = serializeFunc ?? throw new ArgumentNullException(nameof(serializeFunc));
        }

        public T? Serialize<T>(ISteamerSerializerDataProvider provider)
        {
            _ = provider ?? throw new ArgumentNullException(nameof(provider));
            var data = provider.GetData() ?? throw new ArgumentNullException(nameof(provider.GetData));

            return (T)SerializeFunc(data, typeof(T));
        }
    }
}