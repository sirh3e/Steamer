using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser
{
    public interface ISteamerWebSteamUserInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebFriendListRequestBuilder FriendList { get; }
        public ISteamerWebPlayerBansRequestBuilder PlayerBans { get; }
        public ISteamerWebPlayerSummariesRequestBuilder PlayerSummaries { get; }
        public ISteamerWebResolveVanityUrlRequestBuilder ResolveVanityUrl { get; }
        public ISteamerWebUserGroupListRequestBuilder UserGroupList { get; }
    }
}