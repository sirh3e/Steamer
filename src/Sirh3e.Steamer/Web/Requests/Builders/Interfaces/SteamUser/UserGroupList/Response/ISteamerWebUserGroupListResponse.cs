using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response
{
    public interface ISteamerWebUserGroupListResponse
        : ISteamerResponse<ISteamerWebUserGroupListRequest, SteamerWebResponseModel<SteamerUserGroupListModel>>
    {
    }
}