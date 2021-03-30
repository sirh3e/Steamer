using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Response
{
    public static class SteamerWebNumberOfCurrentPlayersResponseExtension
    {
        public static Task<Result<ISteamerWebNumberOfCurrentPlayersResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebNumberOfCurrentPlayersResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ExecuteAsync(service);
        }
    }
}