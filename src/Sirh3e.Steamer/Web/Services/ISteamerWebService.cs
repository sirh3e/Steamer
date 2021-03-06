﻿using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Web.Services.EconService;
using Sirh3e.Steamer.Web.Services.PlayerService;
using Sirh3e.Steamer.Web.Services.SteamApps;
using Sirh3e.Steamer.Web.Services.SteamUser;
using Sirh3e.Steamer.Web.Services.SteamUserStats;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebService : IDisposable,
        ISteamerWebServiceEconServiceServicesBinders,
        ISteamerWebServicePlayerServiceServicesBinders,
        ISteamerWebServiceSteamAppsBinders,
        ISteamerWebServiceSteamUserServicesBinders,
        ISteamerWebServiceSteamUserStatsBinders
    {
        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }
    }
}