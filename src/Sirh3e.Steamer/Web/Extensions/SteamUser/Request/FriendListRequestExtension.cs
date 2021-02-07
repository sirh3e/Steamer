using System;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Request
{
    public static class FriendListRequestExtension
    {
        public static IFriendListResponse ServiceExecute(this IFriendListRequest request,
                                                         ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}