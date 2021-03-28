using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request
{
    public static class SteamerWebFriendListRequestExtension
    {
        public static ISteamerWebFriendListResponse Execute(this ISteamerWebFriendListRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}