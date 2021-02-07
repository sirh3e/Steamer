using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Models.FriendList;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Response
{
    public class FriendListResponse : IFriendListResponse
    {
        public IFriendListRequest Request { get; init; }
        public Option<FriendsListModel> Model { get; init; }
    }
}