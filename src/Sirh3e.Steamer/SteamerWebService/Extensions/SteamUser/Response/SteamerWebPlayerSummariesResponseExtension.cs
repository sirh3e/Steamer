﻿using System;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Response
{
    public static class SteamerWebPlayerSummariesResponseExtension
    {
        //ToDo find a better name for it
        public static ISteamerWebPlayerSummariesResponse RetryServiceExecute(this ISteamerWebPlayerSummariesResponse response,
                                                                             ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}