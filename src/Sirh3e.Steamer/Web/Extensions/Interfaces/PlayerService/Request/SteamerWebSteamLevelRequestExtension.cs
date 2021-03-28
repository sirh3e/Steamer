using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Request
{
    public static class SteamerWebSteamLevelRequestExtension
    {
        public static ISteamerWebSteamLevelResponse Execute(this ISteamerWebSteamLevelRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}