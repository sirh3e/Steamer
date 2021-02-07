using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface ISteamerWebServiceUserGroupListBinder : ISteamerServiceBinder<ISteamerWebUserGroupListRequest,
        ISteamerWebUserGroupListResponse>
    {
    }
}