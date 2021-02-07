using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Request
{
    public static class SteamerWebUserGroupListRequestExtension
    {
        public static ISteamerWebUserGroupListResponse ServiceExecute(this ISteamerWebUserGroupListRequest request,
                                                                      ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}