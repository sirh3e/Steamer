﻿using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats
{
    public interface ISteamerWebSteamUserStatsInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebSchemaForGameRequestBuilder SchemaForGame { get; }
        public ISteamerWebUserStatsForGameRequestBuilder UserStatsForGame { get; }
    }
}