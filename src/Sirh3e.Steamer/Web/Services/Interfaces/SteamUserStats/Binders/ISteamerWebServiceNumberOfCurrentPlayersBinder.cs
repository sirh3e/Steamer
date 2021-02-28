using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats.Binders
{
    public interface ISteamerWebServiceNumberOfCurrentPlayersBinder
        : ISteamerServiceBinder<ISteamerWebNumberOfCurrentPlayersRequest, ISteamerWebNumberOfCurrentPlayersResponse>
    {
    }
}