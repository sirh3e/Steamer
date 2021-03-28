using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamApps.Request
{
    public static class SteamerWebAppListRequestExtension
    {
        public static ISteamerWebAppListResponse Execute(this ISteamerWebAppListRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}