using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request
{
    public class SteamerWebRecentlyPlayedGamesRequestBuilder
        : SteamerRequestBuilder<SteamerWebRecentlyPlayedGamesRequestBuilder, ISteamerWebRecentlyPlayedGamesRequest>,
            ISteamerWebRecentlyPlayedGamesRequestBuilder
    {
        public SteamerWebRecentlyPlayedGamesRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebRecentlyPlayedGamesRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebRecentlyPlayedGamesRequest Build()
        {
            var request = Request;

            Request = new SteamerWebRecentlyPlayedGamesRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebRecentlyPlayedGamesRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebRecentlyPlayedGamesRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public ISteamerWebRecentlyPlayedGamesRequestBuilder SetCount(uint count)
            => SetValue("count", count);
    }
}