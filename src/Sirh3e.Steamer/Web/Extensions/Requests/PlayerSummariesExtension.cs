using System;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Requests
{
    public static class PlayerSummariesExtension
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