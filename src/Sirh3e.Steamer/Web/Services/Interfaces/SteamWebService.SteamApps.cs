using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public Task<Result<ISteamerWebAppListResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebAppListRequest request)
        {
            var response = new SteamerWebAppListResponse();

            return MapAsync<SteamerWebAppListResponse, ISteamerWebAppListResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }
    }
}