using System;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request
{
    public static class SteamerWebFriendListRequestExtension
    {
        public static ISteamerWebFriendListResponse ServiceExecute(this ISteamerWebFriendListRequest request,
                                                                   ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}