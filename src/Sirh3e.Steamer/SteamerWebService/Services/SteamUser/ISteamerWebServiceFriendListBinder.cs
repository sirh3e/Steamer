using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Response;

namespace Sirh3e.Steamer.SteamerWebService.Services.SteamUser
{
    public interface ISteamerWebServiceFriendListBinder
        : ISteamerServiceBinder<ISteamerWebFriendListRequest, ISteamerWebFriendListResponse>
    {
    }
}