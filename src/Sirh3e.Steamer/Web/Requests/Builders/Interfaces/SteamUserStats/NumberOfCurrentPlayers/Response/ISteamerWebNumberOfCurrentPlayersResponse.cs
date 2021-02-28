using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamUserStats.NumberOfCurrentPlayers;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Response
{
    public interface ISteamerWebNumberOfCurrentPlayersResponse : ISteamerResponse<ISteamerWebNumberOfCurrentPlayersRequest,
        SteamerWebNumberOfCurrentPlayersModel>
    {
    }
}