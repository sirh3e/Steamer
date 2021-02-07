namespace Sirh3e.Steamer.Core.Serializers.Providers
{
    public interface ISteamerSerializerProvider
    {
        public ISteamerSerializer Serializer { get; }
    }
}