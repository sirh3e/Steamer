using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request
{
    public class SteamerWebUserStatsForGameRequestBuilder
        : SteamerRequestBuilder<SteamerWebUserStatsForGameRequestBuilder, ISteamerWebUserStatsForGameRequest>,
            ISteamerWebUserStatsForGameRequestBuilder
    {
        public SteamerWebUserStatsForGameRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebUserStatsForGameRequest(Interface ??
                                                            throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebUserStatsForGameRequest Build()
        {
            var request = Request;

            Request = new SteamerWebUserStatsForGameRequest(Interface ??
                                                            throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebUserStatsForGameRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebUserStatsForGameRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public ISteamerWebUserStatsForGameRequestBuilder SetAppId(uint appId)
            => SetValue("appid", appId);
    }
}