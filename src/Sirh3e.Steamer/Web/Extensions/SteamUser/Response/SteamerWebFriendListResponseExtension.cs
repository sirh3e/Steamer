﻿using System;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Response;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Response
{
    public static class SteamerWebFriendListResponseExtension
    {
        public static ISteamerWebFriendListResponse RetryServiceExecute(this ISteamerWebFriendListResponse response,
                                                                        ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}