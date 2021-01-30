using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;

namespace Sirh3e.Steamer.Web.Builders.SteamUser
{
    public class SteamerUserInterfaceBuilder : SteamerInterface, ISteamerUserInterfaceBuilder
    {
        public SteamerUserInterfaceBuilder() : base("ISteamUser")
        {
            PlayerBans = new PlayerBansRequestBuilder(this);
        }

        public IPlayerBansRequestBuilder PlayerBans { get; }
    }
}