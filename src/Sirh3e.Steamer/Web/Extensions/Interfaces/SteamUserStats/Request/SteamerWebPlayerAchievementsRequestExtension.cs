using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request
{
    public static class SteamerWebPlayerAchievementsRequestExtension
    {
        public static ISteamerWebPlayerAchievementsResponse Execute(
            this ISteamerWebPlayerAchievementsRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}