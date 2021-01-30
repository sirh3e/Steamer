using System;
using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Net.Http;
using Sirh3e.Steamer.Web.Services.SteamUser;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebService : IDisposable, ISteamerWebServiceSteamUserServiceBinder
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}