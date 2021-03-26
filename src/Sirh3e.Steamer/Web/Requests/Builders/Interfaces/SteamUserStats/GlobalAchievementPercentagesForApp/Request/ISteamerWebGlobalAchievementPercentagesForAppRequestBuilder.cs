using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request
{
    public interface
        ISteamerWebGlobalAchievementPercentagesForAppRequestBuilder : ISteamerRequestBuilder<
            ISteamerWebGlobalAchievementPercentagesForAppRequest>
    {
        public ISteamerWebGlobalAchievementPercentagesForAppRequestBuilder SetGameId(uint gameId);
    }
}