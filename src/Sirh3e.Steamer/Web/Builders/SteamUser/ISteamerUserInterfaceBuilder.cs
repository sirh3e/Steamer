using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;

namespace Sirh3e.Steamer.Web.Builders.SteamUser
{
    public interface ISteamerUserInterfaceBuilder : ISteamerInterface
    {
        public IPlayerBansRequestBuilder PlayerBans { get; }
    }
}