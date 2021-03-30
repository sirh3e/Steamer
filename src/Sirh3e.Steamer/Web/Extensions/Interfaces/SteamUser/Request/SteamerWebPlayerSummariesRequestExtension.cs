using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request
{
    public static class SteamerWebPlayerSummariesRequestExtension
    {
        public static Task<Result<ISteamerWebPlayerSummariesResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebPlayerSummariesRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}