using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Response;

namespace Sirh3e.Steamer.Web.Services.PlayerService.Binders
{
    public interface ISteamerWebServiceRecentlyPlayedGamesBinder
        : ISteamerServiceBinder<ISteamerWebRecentlyPlayedGamesRequest, ISteamerWebRecentlyPlayedGamesResponse>
    {
    }
}