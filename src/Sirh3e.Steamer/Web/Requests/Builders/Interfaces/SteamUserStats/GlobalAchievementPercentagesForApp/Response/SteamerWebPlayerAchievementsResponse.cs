using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamUserStats.GlobalAchievementPercentagesForApp;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Response
{
    public class SteamerWebGlobalAchievementPercentagesForAppResponse : ISteamerWebGlobalAchievementPercentagesForAppResponse
    {
        public ISteamerWebGlobalAchievementPercentagesForAppRequest Request { get; init; }
        public Option<SteamerWebSteamerWebGlobalAchievementPercentagesForAppModelResponseModel> Model { get; init; }
    }
}