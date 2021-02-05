using System;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Response
{
    public static class PlayerSummariesResponseExtension
    {
        //ToDo find a better name for it
        public static IPlayerSummariesResponse RetryServiceExecute(this IPlayerSummariesResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}