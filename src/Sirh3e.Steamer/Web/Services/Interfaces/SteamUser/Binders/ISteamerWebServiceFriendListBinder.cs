using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser.Binders
{
    public interface ISteamerWebServiceFriendListBinder
        : ISteamerServiceBinder<ISteamerWebFriendListRequest, ISteamerWebFriendListResponse>
    {
    }
}