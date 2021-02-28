using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamUserStats.PlayerAchievements;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Response
{
    public interface ISteamerWebPlayerAchievementsResponse : ISteamerResponse<ISteamerWebPlayerAchievementsRequest,
        SteamerWebPlayerAchievementsModel>
    {
    }
}