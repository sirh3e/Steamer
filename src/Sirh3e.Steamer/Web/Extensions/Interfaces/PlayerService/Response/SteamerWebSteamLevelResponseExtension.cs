using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Response
{
    public static class SteamerWebSteamLevelResponseExtension
    {
        public static Task<Result<ISteamerWebSteamLevelResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebSteamLevelResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ExecuteAsync(service);
        }
    }
}