using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser
{
    public interface ISteamerWebUserInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebFriendListRequestBuilder SteamerWebFriendList { get; }
        public ISteamerWebPlayerBansRequestBuilder SteamerWebPlayerBans { get; }
        public ISteamerWebPlayerSummariesRequestBuilder SteamerWebPlayerSummaries { get; }
        public ISteamerWebResolveVanityUrlRequestBuilder SteamerWebResolveVanityUrl { get; }
    }
}