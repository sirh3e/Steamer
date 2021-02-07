using Sirh3e.Steamer.Web.Services.SteamUser;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebServiceSteamUserServicesBinders :
        ISteamerWebServiceFriendListBinder,
        ISteamerWebServicePlayerBansBinder,
        ISteamerWebServicePlayerSummariesBinder,
        ISteamerWebServiceResolveVanityUrlBinder,
        ISteamerWebServiceUserGroupListBinder
    {
    }
}