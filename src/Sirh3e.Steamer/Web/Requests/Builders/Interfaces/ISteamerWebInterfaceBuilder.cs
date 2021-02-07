using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerWebUserInterfaceBuilder SteamUser { get; }
    }
}