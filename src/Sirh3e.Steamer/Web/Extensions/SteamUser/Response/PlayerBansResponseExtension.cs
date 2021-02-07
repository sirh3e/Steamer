using System;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Response
{

    //ToDo find a better name for it
    public static class PlayerBansResponseExtension
    {
        public static IPlayerBansResponse RetryServiceExecute(this IPlayerBansResponse response,
                                                              ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}