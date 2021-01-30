using Sirh3e.Steamer.Web.Builders.SteamUser;

namespace Sirh3e.Steamer.Web.Builders
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerUserInterfaceBuilder SteamerUser { get; }
    }
}