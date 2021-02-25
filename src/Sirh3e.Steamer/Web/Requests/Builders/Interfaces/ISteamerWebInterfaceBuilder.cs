using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerWebEconServiceInterfaceBuilder EconService { get; }
        public ISteamerWebUserInterfaceBuilder SteamUser { get; }
    }
}