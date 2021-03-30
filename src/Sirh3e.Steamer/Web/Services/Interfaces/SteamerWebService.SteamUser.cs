using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public Task<Result<ISteamerWebFriendListResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebFriendListRequest request)
        {
            var response = new SteamerWebFriendListResponse();

            return MapAsync<SteamerWebFriendListResponse, ISteamerWebFriendListResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebPlayerSummariesResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebPlayerSummariesRequest request)
        {
            var response = new SteamerWebPlayerSummariesResponse();

            return MapAsync<SteamerWebPlayerSummariesResponse, ISteamerWebPlayerSummariesResponse>(ExecuteAsync(request,
                response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebUserGroupListResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebUserGroupListRequest request)
        {
            var response = new SteamerWebUserGroupListResponse();

            return MapAsync<SteamerWebUserGroupListResponse, ISteamerWebUserGroupListResponse>(ExecuteAsync(request,
                response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebPlayerBansResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebPlayerBansRequest request)
        {
            var response = new SteamerWebPlayerBansResponse();

            return MapAsync<SteamerWebPlayerBansResponse, ISteamerWebPlayerBansResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebResolveVanityUrlResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebResolveVanityUrlRequest request)
        {
            var response = new SteamerWebResolveVanityUrlResponse();

            return MapAsync<SteamerWebResolveVanityUrlResponse, ISteamerWebResolveVanityUrlResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }
    }
}