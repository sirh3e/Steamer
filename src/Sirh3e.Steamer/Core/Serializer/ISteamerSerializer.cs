using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Core.Serializer
{
    public interface ISteamerSerializer
    {
        public T? Serialize<T>(ISteamerSerializerDataProvider provider);
    }
}