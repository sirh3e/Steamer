﻿using System;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Response
{
    public static class SteamerWebSchemaForGameResponseExtension
    {
        public static ISteamerWebSchemaForGameResponse RetryServiceExecute(this ISteamerWebSchemaForGameResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}