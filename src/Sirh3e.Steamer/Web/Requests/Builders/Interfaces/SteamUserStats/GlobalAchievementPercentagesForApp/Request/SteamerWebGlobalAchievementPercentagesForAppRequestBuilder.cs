using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request
{
    public class SteamerWebGlobalAchievementPercentagesForAppRequestBuilder
        : SteamerRequestBuilder<SteamerWebGlobalAchievementPercentagesForAppRequestBuilder,
                ISteamerWebGlobalAchievementPercentagesForAppRequest>,
            ISteamerWebGlobalAchievementPercentagesForAppRequestBuilder
    {
        public SteamerWebGlobalAchievementPercentagesForAppRequestBuilder(ISteamerInterface @interface) :
            base(@interface)
        {
            Request = new SteamerWebGlobalAchievementPercentagesForAppRequest(Interface ??
                                                                              throw new ArgumentNullException(
                                                                                  nameof(Interface)));
        }

        public override ISteamerWebGlobalAchievementPercentagesForAppRequest Build()
        {
            var request = Request;

            Request = new SteamerWebGlobalAchievementPercentagesForAppRequest(Interface ??
                                                                              throw new ArgumentNullException(
                                                                                  nameof(Interface)));

            return request;
        }

        public ISteamerWebGlobalAchievementPercentagesForAppRequestBuilder SetGameId(uint gameId)
            => SetValue("gameid", gameId);
    }
}