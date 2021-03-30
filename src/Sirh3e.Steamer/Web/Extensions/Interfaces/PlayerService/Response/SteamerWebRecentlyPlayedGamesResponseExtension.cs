using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Response
{
    public static class SteamerWebRecentlyPlayedGamesResponseExtension
    {
        public static Task<Result<ISteamerWebRecentlyPlayedGamesResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebRecentlyPlayedGamesResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ExecuteAsync(service);
        }
    }
}