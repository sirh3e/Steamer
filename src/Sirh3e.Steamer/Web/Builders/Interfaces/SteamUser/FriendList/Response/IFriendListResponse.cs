using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Models.FriendList;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Response
{
    public interface IFriendListResponse : ISteamerResponse<IFriendListRequest, FriendsListModel>
    {
    }
}