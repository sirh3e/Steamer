using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public ISteamerWebRecentlyPlayedGamesResponse Execute(ISteamerWebRecentlyPlayedGamesRequest request)
        {
            var response = new SteamerWebRecentlyPlayedGamesResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}