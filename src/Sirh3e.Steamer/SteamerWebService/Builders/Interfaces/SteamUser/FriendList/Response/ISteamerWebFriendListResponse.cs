using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Models.FriendList;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Response
{
    public interface ISteamerWebFriendListResponse : ISteamerResponse<ISteamerWebFriendListRequest, SteamerWebFriendsListModel>
    {
    }
}