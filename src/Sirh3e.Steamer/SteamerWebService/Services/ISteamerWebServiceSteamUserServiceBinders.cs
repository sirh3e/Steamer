using Sirh3e.Steamer.SteamerWebService.Services.SteamUser;

namespace Sirh3e.Steamer.SteamerWebService.Services
{
    public interface ISteamerWebServiceSteamUserServiceBinders :
        ISteamerWebServiceFriendListBinder,
        ISteamerWebServicePlayerBansBinder,
        ISteamerWebServicePlayerSummariesBinder,
        ISteamerWebServiceResolveVanityUrlBinder
    {
    }
}