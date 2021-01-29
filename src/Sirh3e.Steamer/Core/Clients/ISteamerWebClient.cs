using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Builders;

namespace Sirh3e.Steamer.Core.Clients
{
    public interface ISteamerWebClient : ISteamWebInterfaceBuilder
    {
        public ISteamerAuthProvider AuthProvider { get; }
        public ISteamerSerializerProvider SerializerProvider { get; }
    }
}