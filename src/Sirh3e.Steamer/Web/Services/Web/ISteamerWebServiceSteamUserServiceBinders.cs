using Sirh3e.Steamer.Web.Services.Web.SteamUser;

namespace Sirh3e.Steamer.Web.Services.Web
{
    public interface ISteamerWebServiceSteamUserServiceBinders :
        ISteamerWebServiceFriendListBinder,
        ISteamerWebServicePlayerBansBinder,
        ISteamerWebServicePlayerSummariesBinder
    {
    }
}