﻿using System;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request
{
    public static class PlayerSummariesRequestExtension
    {
        public static IPlayerSummariesResponse ServiceExecute(this IPlayerSummariesRequest request,
                                                              ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}