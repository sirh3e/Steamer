using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request
{
    public static class SteamerWebUserStatsForGameRequestExtension
    {
        public static Task<Result<ISteamerWebUserStatsForGameResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebUserStatsForGameRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}