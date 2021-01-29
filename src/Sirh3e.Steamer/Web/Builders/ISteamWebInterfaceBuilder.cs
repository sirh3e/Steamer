using Sirh3e.Steamer.Web.Builders.SteamUser;

namespace Sirh3e.Steamer.Web.Builders
{
    public interface ISteamWebInterfaceBuilder
    {
        public ISteamUserInterfaceBuilder SteamUser { get; }
    }
}