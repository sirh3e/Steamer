using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Response;

namespace Sirh3e.Steamer.Web.Services.PlayerService.Binders
{
    public interface ISteamerWebServiceOwnedGamesGamesBinder
        : ISteamerServiceBinder<ISteamerWebOwnedGamesRequest, ISteamerWebOwnedGamesResponse>
    {
    }
}