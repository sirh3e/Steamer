using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps
{
    public interface ISteamerWebSteamAppsInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebAppListRequestBuilder AppList { get; }
    }
}