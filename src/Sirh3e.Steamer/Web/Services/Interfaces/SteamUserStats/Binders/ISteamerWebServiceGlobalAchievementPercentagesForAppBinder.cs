using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats.Binders
{
    public interface ISteamerWebServiceGlobalAchievementPercentagesForAppBinder
        : ISteamerServiceBinder<ISteamerWebGlobalAchievementPercentagesForAppRequest, ISteamerWebGlobalAchievementPercentagesForAppResponse>
    {
    }
}