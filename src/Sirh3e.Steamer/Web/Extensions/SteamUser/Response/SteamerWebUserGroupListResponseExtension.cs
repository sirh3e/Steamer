using System;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response;

namespace Sirh3e.Steamer.Web.Extensions.SteamUser.Response
{
    public static class SteamerWebUserGroupListResponseExtension
    {
        //ToDo find a better name for it
        public static ISteamerWebUserGroupListResponse RetryServiceExecute(this ISteamerWebUserGroupListResponse response,
                                                                           ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}