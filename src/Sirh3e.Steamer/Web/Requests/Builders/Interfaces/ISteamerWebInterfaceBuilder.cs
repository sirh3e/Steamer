﻿using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerWebEconServiceInterfaceBuilder EconService { get; }
        public ISteamerWebPlayerServiceInterfaceBuilder PlayerService { get; }
        public ISteamerWebSteamAppsInterfaceBuilder SteamApps { get; }
        public ISteamerWebSteamUserInterfaceBuilder SteamUser { get; }
        public ISteamerWebSteamUserStatsInterfaceBuilder SteamUserStats { get; }
    }
}