using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request;

namespace Sirh3e.Steamer.Web.Builders.SteamUser
{
    public interface ISteamerUserInterfaceBuilder : ISteamerInterface
    {
        public IFriendListRequestBuilder FriendList { get; }
        public IPlayerBansRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestBuilder PlayerSummaries { get; }
    }
}