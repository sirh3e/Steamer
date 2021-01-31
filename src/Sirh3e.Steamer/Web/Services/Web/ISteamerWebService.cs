using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Net.Http;

namespace Sirh3e.Steamer.Web.Services.Web
{
    public interface ISteamerWebService : IDisposable, ISteamerWebServiceSteamUserServiceBinders
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}