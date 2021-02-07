using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser;

namespace Sirh3e.Steamer.Web.Builders.Interfaces
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerUserInterfaceBuilder SteamerUser { get; }
    }
}