using System;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;

namespace Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request
{
    public static class SteamerWebPlayerSummariesRequestExtension
    {
        public static ISteamerWebPlayerSummariesResponse ServiceExecute(this ISteamerWebPlayerSummariesRequest request,
                                                                        ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}