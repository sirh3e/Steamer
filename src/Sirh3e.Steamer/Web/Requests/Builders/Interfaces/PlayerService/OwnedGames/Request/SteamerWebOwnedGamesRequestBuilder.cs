using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request
{
    public class SteamerWebOwnedGamesRequestBuilder
        : SteamerRequestBuilder<SteamerWebOwnedGamesRequestBuilder, ISteamerWebOwnedGamesRequest>,
            ISteamerWebOwnedGamesRequestBuilder
    {
        public SteamerWebOwnedGamesRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new SteamerWebOwnedGamesRequest(Interface ??
                                                      throw new ArgumentNullException(nameof(Interface)));
        }

        public override ISteamerWebOwnedGamesRequest Build()
        {
            var request = Request;

            Request = new SteamerWebOwnedGamesRequest(Interface ??
                                                      throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebOwnedGamesRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebOwnedGamesRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public ISteamerWebOwnedGamesRequestBuilder SetIncludeAppInfo(bool includeAppInfo)
            => SetValue("include_appinfo", includeAppInfo);

        public ISteamerWebOwnedGamesRequestBuilder SetIncludePlayedFreeGames(bool includePlayedFreeGames)
            => SetValue("include_played_free_games", includePlayedFreeGames);

        public ISteamerWebOwnedGamesRequestBuilder SetAppIdsFilter(uint appIdsFilter)
            => SetValue("appids_filter", appIdsFilter);
    }
}