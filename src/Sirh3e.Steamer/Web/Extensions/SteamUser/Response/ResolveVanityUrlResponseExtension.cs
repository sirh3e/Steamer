using System;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Response
{
    public static class ResolveVanityUrlResponseExtension
    {
        //ToDo find a better name for it
        public static IResolveVanityUrlResponse RetryServiceExecute(this IResolveVanityUrlResponse response,
                                                                    ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}