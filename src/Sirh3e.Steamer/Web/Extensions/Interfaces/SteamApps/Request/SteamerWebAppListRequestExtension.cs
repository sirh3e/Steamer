using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamApps.Request
{
    public static class SteamerWebAppListRequestExtension
    {
        public static Task<Result<ISteamerWebAppListResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebAppListRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}