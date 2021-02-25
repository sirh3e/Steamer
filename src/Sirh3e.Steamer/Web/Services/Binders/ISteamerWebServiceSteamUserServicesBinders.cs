using Sirh3e.Steamer.Web.Services.Binders.SteamUser;

namespace Sirh3e.Steamer.Web.Services.Binders
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