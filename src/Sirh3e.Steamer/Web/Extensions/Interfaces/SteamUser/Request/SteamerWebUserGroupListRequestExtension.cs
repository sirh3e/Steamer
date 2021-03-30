using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request
{
    public static class SteamerWebUserGroupListRequestExtension
    {
        public static Task<Result<ISteamerWebUserGroupListResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebUserGroupListRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}