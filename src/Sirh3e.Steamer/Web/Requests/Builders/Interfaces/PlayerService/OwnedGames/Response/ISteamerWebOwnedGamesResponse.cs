using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.OwnedGames;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Response
{
    public interface ISteamerWebOwnedGamesResponse : ISteamerResponse<ISteamerWebOwnedGamesRequest,
        SteamerWebResponseModel<SteamerWebOwnedGamesModel>>
    {
    }
}