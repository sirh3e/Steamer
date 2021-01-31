using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Builders.SteamUser
{
    public class SteamerUserInterfaceBuilder : SteamerInterface, ISteamerUserInterfaceBuilder
    {
        public SteamerUserInterfaceBuilder() : base("ISteamUser")
        {
            PlayerBans = new PlayerBansRequestBuilder(this);
            PlayerSummaries = new PlayerSummariesRequestBuilder(this);
        }

        public IPlayerBansRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestBuilder PlayerSummaries { get; }
    }
}