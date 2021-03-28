using System;
using Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Response
{
    public static class SteamerWebOwnedGamesResponseExtension
    {
        public static ISteamerWebOwnedGamesResponse Reexecute(this ISteamerWebOwnedGamesResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.Execute(service);
        }
    }
}