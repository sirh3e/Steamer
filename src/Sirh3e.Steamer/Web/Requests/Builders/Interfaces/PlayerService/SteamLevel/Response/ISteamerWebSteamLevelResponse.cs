using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.RecentlyPlayedGames;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response
{
    public interface ISteamerWebRecentlyPlayedGamesResponse : ISteamerResponse<ISteamerWebRecentlyPlayedGamesRequest,
        SteamerWebResponseModel<SteamerWebRecentlyPlayedGamesModel>>
    {
    }
}