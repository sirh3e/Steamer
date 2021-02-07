using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Models.FriendList;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Request;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Response
{
    public interface ISteamerWebFriendListResponse : ISteamerResponse<ISteamerWebFriendListRequest, SteamerWebFriendsListModel>
    {
    }
}