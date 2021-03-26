using System;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Internal.System;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web
{
    public static class SteamerWebFactory
    {
        public static (SteamerWebClient, SteamerWebService) CreateByApiKey(string apiKey)
        {
            _ = apiKey.IsNullOrEmpty() ?? throw new ArgumentNullException(nameof(apiKey));

            var authProvider = SteamerAuthProvider.Factory.CreateByApiKey(apiKey);

            var webClient = SteamerWebClient.Factory.CreateByAuthProvider(authProvider);
            var httpClientProvider = SteamerHttpClientProvider.Factory.CreateDefault();

            var service = new SteamerWebService.Builder()
                .SetWebClient(webClient)
                .SetHttpClientProvider(httpClientProvider)
                .Build();

            return (webClient, service);
        }
    }
}