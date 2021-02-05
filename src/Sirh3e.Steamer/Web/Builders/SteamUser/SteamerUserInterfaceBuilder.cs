using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request;

namespace Sirh3e.Steamer.Web.Builders.SteamUser
{
    public class SteamerUserInterfaceBuilder : SteamerInterface, ISteamerUserInterfaceBuilder
    {
        public SteamerUserInterfaceBuilder() : base("ISteamUser")
        {
            FriendList = new FriendListRequestBuilder(this);
            PlayerBans = new PlayerBansRequestBuilder(this);
            PlayerSummaries = new PlayerSummariesRequestBuilder(this);
        }

        public IFriendListRequestBuilder FriendList { get; }
        public IPlayerBansRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestBuilder PlayerSummaries { get; }
    }
}