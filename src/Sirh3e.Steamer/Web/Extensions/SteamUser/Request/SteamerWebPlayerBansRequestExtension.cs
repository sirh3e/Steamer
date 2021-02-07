using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Request
{
    public static class SteamerWebPlayerBansRequestExtension
    {
        public static ISteamerWebPlayerBansResponse ServiceExecute(this ISteamerWebPlayerBansRequest request, ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}