using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request
{
    public static class SteamerWebGlobalAchievementPercentagesForAppRequestExtension
    {
        public static ISteamerWebGlobalAchievementPercentagesForAppResponse Execute(
            this ISteamerWebGlobalAchievementPercentagesForAppRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}