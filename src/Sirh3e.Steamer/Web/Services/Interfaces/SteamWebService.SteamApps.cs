using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public ISteamerWebAppListResponse Execute(ISteamerWebAppListRequest request)
        {
            var response = new SteamerWebAppListResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}