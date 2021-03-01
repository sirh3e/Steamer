using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request
{
    public interface ISteamerWebOwnedGamesRequestBuilder : ISteamerRequestBuilder<ISteamerWebOwnedGamesRequest>
    {
        public ISteamerWebOwnedGamesRequestBuilder SetKey(string key);
        public ISteamerWebOwnedGamesRequestBuilder SetSteamId(ulong steamId);
        public ISteamerWebOwnedGamesRequestBuilder SetIncludeAppInfo(bool includeAppInfo);
        public ISteamerWebOwnedGamesRequestBuilder SetIncludePlayedFreeGames(bool includePlayedFreeGames);
        public ISteamerWebOwnedGamesRequestBuilder SetAppIdsFilter(uint appIdsFilter);
    }
}