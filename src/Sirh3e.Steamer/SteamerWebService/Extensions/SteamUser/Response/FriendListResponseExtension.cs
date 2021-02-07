using System;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Response;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Response
{
    public static class FriendListResponseExtension
    {
        public static IFriendListResponse RetryServiceExecute(this IFriendListResponse response,
                                                              ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}