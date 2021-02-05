using Sirh3e.Steamer.Web.Services.SteamUser;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebServiceSteamUserServiceBinders :
        ISteamerWebServiceFriendListBinder,
        ISteamerWebServicePlayerBansBinder,
        ISteamerWebServicePlayerSummariesBinder
    {
    }
}