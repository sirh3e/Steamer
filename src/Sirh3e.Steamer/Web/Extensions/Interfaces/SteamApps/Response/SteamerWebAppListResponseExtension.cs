using System;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamApps.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamApps.Response
{
    public static class SteamerWebAppListResponseExtension
    {
        public static ISteamerWebAppListResponse Reexecute(this ISteamerWebAppListResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.Execute(service);
        }
    }
}