using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamUser.FriendList;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Response
{
    public class SteamerWebFriendListResponse : ISteamerWebFriendListResponse
    {
        public ISteamerWebFriendListRequest Request { get; init; }
        public Option<SteamerWebFriendsListModel> Model { get; init; }
    }
}