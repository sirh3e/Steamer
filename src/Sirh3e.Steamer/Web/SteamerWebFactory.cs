using System;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Internal.Extensions.System;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web
{
    public static class SteamerWebFactory
    {
        public static (SteamerWebService, SteamerWebClient) CreateByKey(string key)
        {
            _ = key.IsNullOrEmpty() ?? throw new ArgumentNullException(nameof(key));

            var authProvider = SteamerAuthProvider.Factory.CreateByApiKey(key);

            var client = SteamerWebClient.Factory.CreateByAuthProvider(authProvider);
            var httpClientProvider = SteamerHttpClientProvider.Factory.CreateDefault();

            var service = new SteamerWebService.Builder()
                .SetWebClient(client)
                .SetHttpClientProvider(httpClientProvider)
                .Build();

            return (service, client);
        }
    }
}