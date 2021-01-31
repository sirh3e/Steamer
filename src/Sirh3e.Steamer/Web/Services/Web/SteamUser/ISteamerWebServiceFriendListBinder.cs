using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList;

namespace Sirh3e.Steamer.Web.Services.Web.SteamUser
{
    public interface ISteamerWebServiceFriendListBinder
        : ISteamerServiceBinder<IFriendListRequest, IFriendListResponse>
    {
    }
}