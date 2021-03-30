using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request
{
    public static class SteamerWebPlayerBansRequestExtension
    {
        public static Task<Result<ISteamerWebPlayerBansResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebPlayerBansRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}