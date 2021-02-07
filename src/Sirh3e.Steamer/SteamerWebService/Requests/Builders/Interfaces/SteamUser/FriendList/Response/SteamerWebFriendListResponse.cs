using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Models.FriendList;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Request;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Response
{
    public class SteamerWebFriendListResponse : ISteamerWebFriendListResponse
    {
        public ISteamerWebFriendListRequest Request { get; init; }
        public Option<SteamerWebFriendsListModel> Model { get; init; }
    }
}