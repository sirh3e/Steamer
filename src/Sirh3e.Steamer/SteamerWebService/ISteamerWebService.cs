using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.SteamerWebService.Services;

namespace Sirh3e.Steamer.SteamerWebService
{
    public interface ISteamerWebService : IDisposable, ISteamerWebServiceSteamUserServiceBinders
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}