using System;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries;
using Sirh3e.Steamer.Web.Services.Web;

namespace Sirh3e.Steamer.Web.Extensions.Requests.SteamUser
{
    public static class PlayerSummariesRequestExtension
    {
        public static IPlayerSummariesResponse ServiceExecute(this IPlayerSummariesRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}