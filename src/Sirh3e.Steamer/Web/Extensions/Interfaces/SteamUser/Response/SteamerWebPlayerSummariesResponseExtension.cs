using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Response
{
    public static class SteamerWebPlayerSummariesResponseExtension
    {
        //ToDo find a better name for it
        public static Task<Result<ISteamerWebPlayerSummariesResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebPlayerSummariesResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ExecuteAsync(service);
        }
    }
}