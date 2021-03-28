﻿using System;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Response
{
    //ToDo find a better name for it
    public static class SteamerWebPlayerBansResponseExtension
    {
        public static ISteamerWebPlayerBansResponse Reexecute(this ISteamerWebPlayerBansResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.Execute(service);
        }
    }
}