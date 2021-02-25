using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Web.Services.Binders;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebService : IDisposable,
                                          ISteamerWebServiceEconServiceServicesBinder,
                                          ISteamerWebServiceSteamUserServicesBinders
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}