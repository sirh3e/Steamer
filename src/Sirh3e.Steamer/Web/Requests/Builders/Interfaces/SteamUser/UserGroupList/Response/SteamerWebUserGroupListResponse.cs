using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response
{
    public class SteamerWebUserGroupListResponse : ISteamerWebUserGroupListResponse
    {
        public ISteamerWebUserGroupListRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerUserGroupListModel>> Model { get; init; }
    }
}