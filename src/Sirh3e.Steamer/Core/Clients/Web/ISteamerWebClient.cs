using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces;

namespace Sirh3e.Steamer.Core.Clients.Web
{
    public interface ISteamerWebClient : ISteamerWebInterfaceBuilder
    {
        public ISteamerAuthProvider AuthProvider { get; }
        public ISteamerSerializerProvider SerializerProvider { get; }
    }
}