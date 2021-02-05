namespace Sirh3e.Steamer.Core.Serializer.Providers
{
    public interface ISteamerSerializerProvider
    {
        public ISteamerSerializer Serializer { get; }
    }
}