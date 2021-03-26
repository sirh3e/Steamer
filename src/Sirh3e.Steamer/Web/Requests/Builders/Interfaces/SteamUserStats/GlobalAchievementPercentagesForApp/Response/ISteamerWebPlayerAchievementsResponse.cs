using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamUserStats.GlobalAchievementPercentagesForApp;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Response
{
    public interface ISteamerWebGlobalAchievementPercentagesForAppResponse : ISteamerResponse<
        ISteamerWebGlobalAchievementPercentagesForAppRequest,
        SteamerWebSteamerWebGlobalAchievementPercentagesForAppModelResponseModel>
    {
    }
}