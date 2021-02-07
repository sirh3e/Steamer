using Sirh3e.Steamer.Core.Serializers.Providers;

namespace Sirh3e.Steamer.Core.Serializers
{
    public interface ISteamerSerializer
    {
        public T? Serialize<T>(ISteamerSerializerDataProvider dataProvider);
    }
}