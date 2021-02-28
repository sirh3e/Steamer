using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats
{
    public class SteamerWebSteamUserStatsInterfaceBuilder : SteamerInterface, ISteamerWebSteamUserStatsInterfaceBuilder
    {
        public SteamerWebSteamUserStatsInterfaceBuilder() : base("ISteamUserStats")
        {
            UserStatsForGame = new SteamerWebUserStatsForGameRequestBuilder(this);
        }

        public ISteamerWebUserStatsForGameRequestBuilder UserStatsForGame { get; }
    }
}