using System;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Builders.SteamUser;

namespace Sirh3e.Steamer.Core.Clients
{
    public class SteamerWebClient : ISteamerWebClient
    {
        public SteamerWebClient(ISteamerAuthProvider authProvider, ISteamerSerializerProvider serializerProvider)
        {
            AuthProvider = authProvider ?? throw new ArgumentNullException(nameof(authProvider));
            SerializerProvider = serializerProvider ?? throw new ArgumentNullException(nameof(serializerProvider));
            SteamUser = new SteamerUserInterfaceBuilder();
        }

        public ISteamerAuthProvider AuthProvider { get; }
        public ISteamerSerializerProvider SerializerProvider { get; }
        public ISteamUserInterfaceBuilder SteamUser { get; }

        public class Builder
        {
            public ISteamerAuthProvider AuthProvider { get; set; }
            public ISteamerSerializerProvider SerializerProvider { get; set; }

            public Builder SetAuthProvider(ISteamerAuthProvider authProvider)
            {
                AuthProvider = authProvider ?? throw new ArgumentNullException(nameof(authProvider));
                return this;
            }

            public Builder SetSerializerProvider(ISteamerSerializerProvider serializerProvider)
            {
                SerializerProvider = serializerProvider ?? throw new ArgumentNullException(nameof(serializerProvider));
                return this;
            }

            public SteamerWebClient Build()
            {
                return new(AuthProvider ?? throw new ArgumentNullException(nameof(AuthProvider)), SerializerProvider ?? throw new ArgumentNullException(nameof(SerializerProvider)));
            }
        }
    }
}