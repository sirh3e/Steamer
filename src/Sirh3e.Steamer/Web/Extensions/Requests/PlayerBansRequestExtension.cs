using System;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Requests
{
    public static class PlayerBansRequestExtension
    {
        public static IPlayerBansResponse ServiceCall(this IPlayerBansRequest request, ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Call(request);
        }
    }
}