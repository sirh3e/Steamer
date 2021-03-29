using System;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.SteamUser.ResolveVanityUrl;
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
        public ISteamerWebFriendListResponse Execute(ISteamerWebFriendListRequest request)
        {
            var response = new SteamerWebFriendListResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebPlayerBansResponse Execute(ISteamerWebPlayerBansRequest request)
            => Execute<SteamerWebPlayerBansResponse>(request ?? throw new ArgumentNullException(nameof(request)));

        public ISteamerWebPlayerBansResponse Execute<TResponse>(ISteamerWebPlayerBansRequest request)
            where TResponse : ISteamerWebPlayerBansResponse, new()
        {
            var response = new TResponse();
            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebPlayerSummariesResponse Execute(ISteamerWebPlayerSummariesRequest request)
        {
            var response = new SteamerWebPlayerSummariesResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebResolveVanityUrlResponse Execute(ISteamerWebResolveVanityUrlRequest request)
            => Execute<SteamerWebResolveVanityUrlResponse>(request);

        public ISteamerWebResolveVanityUrlResponse Execute<TResponse>(ISteamerWebResolveVanityUrlRequest request)
            where TResponse : ISteamerWebResolveVanityUrlResponse, new()
        {
            var response = new TResponse();
            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebUserGroupListResponse Execute(ISteamerWebUserGroupListRequest request)
        {
            var response = new SteamerWebUserGroupListResponse();

            return Execute(request, response, response.Model.Unwrap);
        }
    }
}