using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request
{
    public interface ISteamerWebUserStatsForGameRequestBuilder : ISteamerRequestBuilder<ISteamerWebUserStatsForGameRequest>
    {
        public ISteamerWebUserStatsForGameRequestBuilder SetKey(string key);
        public ISteamerWebUserStatsForGameRequestBuilder SetSteamId(ulong steamId);
        public ISteamerWebUserStatsForGameRequestBuilder SetAppId(uint appId);
    }
}