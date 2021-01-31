using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Builders.SteamUser
{
    public interface ISteamerUserInterfaceBuilder : ISteamerInterface
    {
        public IFriendListRequestBuilder FriendList { get; }
        public IPlayerBansRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestBuilder PlayerSummaries { get; }
    }
}