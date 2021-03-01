using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public ISteamerWebOwnedGamesResponse Execute(ISteamerWebOwnedGamesRequest request)
        {
            var response = new SteamerWebOwnedGamesResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebRecentlyPlayedGamesResponse Execute(ISteamerWebRecentlyPlayedGamesRequest request)
        {
            var response = new SteamerWebRecentlyPlayedGamesResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}