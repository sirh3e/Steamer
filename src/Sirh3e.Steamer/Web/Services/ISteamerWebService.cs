using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebService : IDisposable, ISteamerWebServiceSteamUserServiceBinders
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}