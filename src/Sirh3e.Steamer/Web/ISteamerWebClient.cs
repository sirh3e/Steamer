using Sirh3e.Steamer.Core.Client;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Builders;

namespace Sirh3e.Steamer.Web
{
    public interface ISteamerWebClient : ISteamWebInterfaceBuilder
    {
        public ISteamerClient Client { get; }
        public ISteamerSerializerProvider SerializerProvider { get; }
    }
}