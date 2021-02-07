﻿using System;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Response
{
    //ToDo find a better name for it
    public static class SteamerWebPlayerBansResponseExtension
    {
        public static ISteamerWebPlayerBansResponse RetryServiceExecute(this ISteamerWebPlayerBansResponse response,
                                                                        ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}