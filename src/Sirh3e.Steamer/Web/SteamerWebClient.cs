using System;
using Sirh3e.Steamer.Core.Client;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Builders.SteamUser;

namespace Sirh3e.Steamer.Web
{
    public class SteamerWebClient : ISteamerWebClient
    {
        public SteamerWebClient(ISteamerClient client, ISteamerSerializerProvider serializerProvider)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            SerializerProvider = serializerProvider ?? throw new ArgumentNullException(nameof(serializerProvider));
            SteamUser = new SteamerUserInterfaceBuilder();
        }

        public ISteamerClient Client { get; }
        public ISteamerSerializerProvider SerializerProvider { get; }
        public ISteamUserInterfaceBuilder SteamUser { get; }

        public class Builder
        {
            public ISteamerClient Client { get; set; }
            public ISteamerSerializerProvider Provider { get; set; }


            public Builder SetClient(ISteamerClient client)
            {
                Client = client ?? throw new ArgumentNullException(nameof(client));
                return this;
            }

            public Builder SetProvider(ISteamerSerializerProvider provider)
            {
                Provider = provider ?? throw new ArgumentNullException(nameof(provider));
                return this;
            }

            public SteamerWebClient Build()
            {
                return new(Client ?? throw new ArgumentNullException(nameof(Client)), Provider ?? throw new ArgumentNullException(nameof(Provider)));
            }
        }
    }
}