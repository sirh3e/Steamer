using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web
{
    public interface ISteamerWebService : IDisposable, ISteamerWebServiceSteamUserServicesBinders
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}