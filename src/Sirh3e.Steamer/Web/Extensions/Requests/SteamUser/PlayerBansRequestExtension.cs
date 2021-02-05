﻿using System;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Requests.SteamUser
{
    public static class PlayerBansRequestExtension
    {
        public static IPlayerBansResponse ServiceExecute(this IPlayerBansRequest request, ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}