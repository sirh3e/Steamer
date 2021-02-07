using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser
{
    public class SteamerWebUserInterfaceBuilder : SteamerInterface, ISteamerWebUserInterfaceBuilder
    {
        public SteamerWebUserInterfaceBuilder() : base("ISteamUser") //ToDo rename
        {
            FriendList = new SteamerWebFriendListRequestBuilder(this);
            PlayerBans = new SteamerWebPlayerBansRequestBuilder(this);
            PlayerSummaries = new SteamerWebPlayerSummariesRequestBuilder(this);
            ResolveVanityUrl = new SteamerWebResolveVanityUrlRequestBuilder(this);
        }

        public ISteamerWebFriendListRequestBuilder FriendList { get; }
        public ISteamerWebPlayerBansRequestBuilder PlayerBans { get; }
        public ISteamerWebPlayerSummariesRequestBuilder PlayerSummaries { get; }
        public ISteamerWebResolveVanityUrlRequestBuilder ResolveVanityUrl { get; }
    }
}