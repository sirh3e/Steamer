using System;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Response
{
    public static class SteamerWebResolveVanityUrlResponseExtension
    {
        //ToDo find a better name for it
        public static ISteamerWebResolveVanityUrlResponse RetryServiceExecute(this ISteamerWebResolveVanityUrlResponse response,
                                                                              ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}