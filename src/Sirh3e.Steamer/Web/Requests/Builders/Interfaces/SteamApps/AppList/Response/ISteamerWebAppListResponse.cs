using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamApps.AppList;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response
{
    public interface ISteamerWebAppListResponse : ISteamerResponse<ISteamerWebAppListRequest,
        SteamerWebAppListResponseModel>
    {
    }
}