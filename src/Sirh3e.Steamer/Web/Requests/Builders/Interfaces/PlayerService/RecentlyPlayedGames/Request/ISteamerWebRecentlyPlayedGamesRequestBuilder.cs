using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request
{
    public interface
        ISteamerWebRecentlyPlayedGamesRequestBuilder : ISteamerRequestBuilder<ISteamerWebRecentlyPlayedGamesRequest>
    {
        public ISteamerWebRecentlyPlayedGamesRequestBuilder SetKey(string key);
        public ISteamerWebRecentlyPlayedGamesRequestBuilder SetSteamId(ulong steamId);
        public ISteamerWebRecentlyPlayedGamesRequestBuilder SetCount(uint count);
    }
}