﻿using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats
{
    public class SteamerWebSteamUserStatsInterfaceBuilder : SteamerInterface, ISteamerWebSteamUserStatsInterfaceBuilder
    {
        public SteamerWebSteamUserStatsInterfaceBuilder() : base("ISteamUserStats")
        {
            GlobalAchievementPercentagesForApp = new SteamerWebGlobalAchievementPercentagesForAppRequestBuilder(this);
            NumberOfCurrentPlayers = new SteamerWebNumberOfCurrentPlayersRequestBuilder(this);
            PlayerAchievements = new SteamerWebPlayerAchievementsRequestBuilder(this);
            SchemaForGame = new SteamerWebSchemaForGameRequestBuilder(this);
            UserStatsForGame = new SteamerWebUserStatsForGameRequestBuilder(this);
        }

        public ISteamerWebGlobalAchievementPercentagesForAppRequestBuilder GlobalAchievementPercentagesForApp { get; }
        public ISteamerWebNumberOfCurrentPlayersRequestBuilder NumberOfCurrentPlayers { get; }
        public ISteamerWebPlayerAchievementsRequestBuilder PlayerAchievements { get; }
        public ISteamerWebSchemaForGameRequestBuilder SchemaForGame { get; }
        public ISteamerWebUserStatsForGameRequestBuilder UserStatsForGame { get; }
    }
}