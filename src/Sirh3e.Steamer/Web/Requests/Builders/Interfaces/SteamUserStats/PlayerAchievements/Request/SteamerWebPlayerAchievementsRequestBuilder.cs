using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request
{
    public class SteamerWebPlayerAchievementsRequestBuilder
        : SteamerRequestBuilder<SteamerWebPlayerAchievementsRequestBuilder, ISteamerWebPlayerAchievementsRequest>,
            ISteamerWebPlayerAchievementsRequestBuilder
    {
        public SteamerWebPlayerAchievementsRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebPlayerAchievementsRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebPlayerAchievementsRequest Build()
        {
            var request = Request;

            Request = new SteamerWebPlayerAchievementsRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebPlayerAchievementsRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebPlayerAchievementsRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public ISteamerWebPlayerAchievementsRequestBuilder SetAppId(uint appId)
            => SetValue("appid", appId);

        public ISteamerWebPlayerAchievementsRequestBuilder SetLanguage(string language)
            => SetValue("l", language ?? throw new ArgumentNullException(nameof(language)));
    }
}