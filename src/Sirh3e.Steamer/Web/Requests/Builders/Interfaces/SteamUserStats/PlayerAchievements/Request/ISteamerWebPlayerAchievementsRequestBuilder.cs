using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request
{
    public interface ISteamerWebPlayerAchievementsRequestBuilder : ISteamerRequestBuilder<ISteamerWebPlayerAchievementsRequest>
    {
        public ISteamerWebPlayerAchievementsRequestBuilder SetKey(string key);
        public ISteamerWebPlayerAchievementsRequestBuilder SetSteamId(ulong steamId);
        public ISteamerWebPlayerAchievementsRequestBuilder SetAppId(uint appId);
        public ISteamerWebPlayerAchievementsRequestBuilder SetLanguage(string language);
    }
}