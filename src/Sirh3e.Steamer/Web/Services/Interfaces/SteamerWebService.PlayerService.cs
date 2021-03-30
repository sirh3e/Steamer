using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
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
        public Task<Result<ISteamerWebBadgesResponse, ISteamerWebError>> ExecuteAsync(ISteamerWebBadgesRequest request)
        {
            var response = new SteamerWebBadgesResponse();

            return MapAsync<SteamerWebBadgesResponse, ISteamerWebBadgesResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebCommunityBadgeProgressResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebCommunityBadgeProgressRequest request)
        {
            var response = new SteamerWebCommunityBadgeProgressResponse();

            return MapAsync<SteamerWebCommunityBadgeProgressResponse, ISteamerWebCommunityBadgeProgressResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebOwnedGamesResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebOwnedGamesRequest request)
        {
            var response = new SteamerWebOwnedGamesResponse();

            return MapAsync<SteamerWebOwnedGamesResponse, ISteamerWebOwnedGamesResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebRecentlyPlayedGamesResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebRecentlyPlayedGamesRequest request)
        {
            var response = new SteamerWebRecentlyPlayedGamesResponse();

            return MapAsync<SteamerWebRecentlyPlayedGamesResponse, ISteamerWebRecentlyPlayedGamesResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebSteamLevelResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebSteamLevelRequest request)
        {
            var response = new SteamerWebSteamLevelResponse();

            return MapAsync<SteamerWebSteamLevelResponse, ISteamerWebSteamLevelResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }
    }
}