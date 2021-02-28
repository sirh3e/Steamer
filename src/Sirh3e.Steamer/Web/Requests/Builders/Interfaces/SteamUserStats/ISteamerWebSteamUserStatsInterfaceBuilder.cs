using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats
{
    public interface ISteamerWebSteamUserStatsInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebNumberOfCurrentPlayersRequestBuilder NumberOfCurrentPlayers { get; }
        public ISteamerWebPlayerAchievementsRequestBuilder PlayerAchievements { get; }
        public ISteamerWebSchemaForGameRequestBuilder SchemaForGame { get; }
        public ISteamerWebUserStatsForGameRequestBuilder UserStatsForGame { get; }
    }
}