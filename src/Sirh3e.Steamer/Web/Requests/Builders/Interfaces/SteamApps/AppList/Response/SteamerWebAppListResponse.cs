using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamApps.AppList;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Response
{
    public class SteamerWebAppListResponse : ISteamerWebAppListResponse
    {
        public ISteamerWebAppListRequest Request { get; init; }
        public Option<SteamerWebAppListResponseModel> Model { get; init; }
    }
}