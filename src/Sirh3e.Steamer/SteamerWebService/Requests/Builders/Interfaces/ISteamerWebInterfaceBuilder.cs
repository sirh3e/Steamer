using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerWebUserInterfaceBuilder SteamUser { get; }
    }
}