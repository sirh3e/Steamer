using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response;

namespace Sirh3e.Steamer.Web.Services.SteamApps.Binders
{
    public interface ISteamerWebServiceAppListBinder
        : ISteamerServiceBinder<ISteamerWebAppListRequest, ISteamerWebAppListResponse>
    {
    }
}