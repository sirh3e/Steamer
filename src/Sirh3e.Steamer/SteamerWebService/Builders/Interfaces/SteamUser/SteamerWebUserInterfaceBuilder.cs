using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser
{
    public class SteamerWebUserInterfaceBuilder : SteamerInterface, ISteamerWebUserInterfaceBuilder
    {
        public SteamerWebUserInterfaceBuilder() : base("ISteamUser")
        {
            SteamerWebFriendList = new SteamerWebFriendListRequestBuilder(this);
            SteamerWebPlayerBans = new SteamerWebPlayerBansRequestBuilder(this);
            SteamerWebPlayerSummaries = new SteamerWebPlayerSummariesRequestBuilder(this);
            SteamerWebResolveVanityUrl = new SteamerWebResolveVanityUrlRequestBuilder(this);
        }

        public ISteamerWebFriendListRequestBuilder SteamerWebFriendList { get; }
        public ISteamerWebPlayerBansRequestBuilder SteamerWebPlayerBans { get; }
        public ISteamerWebPlayerSummariesRequestBuilder SteamerWebPlayerSummaries { get; }
        public ISteamerWebResolveVanityUrlRequestBuilder SteamerWebResolveVanityUrl { get; }
    }
}