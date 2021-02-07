using System;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Request
{
    public static class ResolveVanityUrlRequestExtension
    {
        public static IResolveVanityUrlResponse ServiceExecute(this IResolveVanityUrlRequest request,
                                                              ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}