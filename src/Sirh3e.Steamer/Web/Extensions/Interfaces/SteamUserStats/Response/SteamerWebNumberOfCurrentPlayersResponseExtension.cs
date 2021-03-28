using System;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Response
{
    public static class SteamerWebNumberOfCurrentPlayersResponseExtension
    {
        public static ISteamerWebNumberOfCurrentPlayersResponse Reexecute(
            this ISteamerWebNumberOfCurrentPlayersResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.Execute(service);
        }
    }
}