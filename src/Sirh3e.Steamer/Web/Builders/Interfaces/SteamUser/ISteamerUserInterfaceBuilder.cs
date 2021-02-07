using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Request;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser
{
    public interface ISteamerUserInterfaceBuilder : ISteamerInterface
    {
        public IFriendListRequestBuilder FriendList { get; }
        public IPlayerBansRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestRequestBuilder PlayerSummaries { get; }
    }
}