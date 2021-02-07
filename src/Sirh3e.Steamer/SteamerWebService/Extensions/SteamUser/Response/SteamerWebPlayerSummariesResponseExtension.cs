using System;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request;

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