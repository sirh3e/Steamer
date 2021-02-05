using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface ISteamerWebServiceFriendListBinder
        : ISteamerServiceBinder<IFriendListRequest, IFriendListResponse>
    {
    }
}