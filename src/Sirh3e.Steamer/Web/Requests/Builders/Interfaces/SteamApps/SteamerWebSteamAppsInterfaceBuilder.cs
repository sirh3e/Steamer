using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps
{
    public class SteamerWebSteamAppsInterfaceBuilder : SteamerInterface, ISteamerWebSteamAppsInterfaceBuilder
    {
        public SteamerWebSteamAppsInterfaceBuilder() : base("ISteamApps")
        {
            AppList = new SteamerWebAppListRequestBuilder(this);
        }

        public ISteamerWebAppListRequestBuilder AppList { get; }
    }
}