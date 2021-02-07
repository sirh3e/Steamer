using System;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request
{
    public static class PlayerBansRequestExtension
    {
        public static IPlayerBansResponse ServiceExecute(this IPlayerBansRequest request, ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}