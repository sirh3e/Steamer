using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats.Binders
{
    public interface ISteamerWebServiceUserStatsForGameBinder
        : ISteamerServiceBinder<ISteamerWebUserStatsForGameRequest, ISteamerWebUserStatsForGameResponse>
    {
    }
}