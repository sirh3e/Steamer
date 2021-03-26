using System;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Serializers.Providers;

namespace Sirh3e.Steamer.Core.Clients.Web
{
    public partial class SteamerWebClient : ISteamerWebClient
    {
        public class Builder
        {
            public ISteamerAuthProvider? AuthProvider { get; protected set; }
            public ISteamerSerializerProvider? SerializerProvider { get; protected set; }

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
                => new(AuthProvider ?? throw new ArgumentNullException(nameof(AuthProvider)),
                    SerializerProvider ?? throw new ArgumentNullException(nameof(SerializerProvider)));

            public static implicit operator SteamerWebClient(Builder builder)
                => (_ = builder ?? throw new ArgumentNullException(nameof(builder))).Build();
        }
    }
}