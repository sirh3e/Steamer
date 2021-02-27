using Sirh3e.Steamer.Web.Services.SteamUser.Binders;

namespace Sirh3e.Steamer.Web.Services.SteamUser
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