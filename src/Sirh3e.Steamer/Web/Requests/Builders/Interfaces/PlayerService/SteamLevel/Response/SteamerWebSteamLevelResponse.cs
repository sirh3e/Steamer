using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.SteamLevel;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response
{
    public class SteamerWebSteamLevelResponse : ISteamerWebSteamLevelResponse
    {
        public ISteamerWebSteamLevelRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebSteamLevelModel>> Model { get; init; }
    }
}