using System;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Serializers.Providers;

namespace Sirh3e.Steamer.Core.Clients.Web
{
    public partial class SteamerWebClient : ISteamerWebClient
    {
        public static class Factory
        {
            public static SteamerWebClient CreateByAuthProvider(ISteamerAuthProvider authProvider)
                => new Builder()
                    .SetAuthProvider(authProvider ?? throw new ArgumentNullException(nameof(authProvider)))
                    .SetSerializerProvider(SteamerSerializerProvider.Factory.CreateDefault())
                    .Build();
        }
    }
}