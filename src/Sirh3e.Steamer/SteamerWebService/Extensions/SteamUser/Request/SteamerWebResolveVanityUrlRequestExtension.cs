using System;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request
{
    public static class SteamerWebResolveVanityUrlRequestExtension
    {
        public static ISteamerWebResolveVanityUrlResponse ServiceExecute(this ISteamerWebResolveVanityUrlRequest request,
                                                                         ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}