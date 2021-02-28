using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats.Binders
{
    public interface ISteamerWebServicePlayerAchievementsBinder
        : ISteamerServiceBinder<ISteamerWebPlayerAchievementsRequest, ISteamerWebPlayerAchievementsResponse>
    {
    }
}