using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Request;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser
{
    public class SteamerUserInterfaceBuilder : SteamerInterface, ISteamerUserInterfaceBuilder
    {
        public SteamerUserInterfaceBuilder() : base("ISteamUser")
        {
            FriendList = new FriendListRequestBuilder(this);
            PlayerBans = new PlayerBansRequestRequestBuilder(this);
        }

        public IFriendListRequestBuilder FriendList { get; }
        public IPlayerBansRequestRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestRequestBuilder PlayerSummaries { get; }
    }
}