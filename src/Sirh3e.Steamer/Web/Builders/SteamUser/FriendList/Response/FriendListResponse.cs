using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Models.FriendList;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Response
{
    public class FriendListResponse : IFriendListResponse
    {
        public IFriendListRequest Request { get; set; }
        public Option<FriendsListModel> Model { get; set; }
    }
}