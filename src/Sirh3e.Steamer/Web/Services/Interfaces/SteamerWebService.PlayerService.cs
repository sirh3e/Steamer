using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public ISteamerWebBadgesResponse Execute(ISteamerWebBadgesRequest request)
        {
            var response = new SteamerWebBadgesResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebCommunityBadgeProgressResponse Execute(ISteamerWebCommunityBadgeProgressRequest request)
        {
            var response = new SteamerWebCommunityBadgeProgressResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

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

        public ISteamerWebSteamLevelResponse Execute(ISteamerWebSteamLevelRequest request)
        {
            var response = new SteamerWebSteamLevelResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}