using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Response
{
    public interface ISteamerWebUserStatsForGameResponse : ISteamerResponse<ISteamerWebUserStatsForGameRequest,
        SteamerWebUserStatsForGameModel>
    {
    }
}