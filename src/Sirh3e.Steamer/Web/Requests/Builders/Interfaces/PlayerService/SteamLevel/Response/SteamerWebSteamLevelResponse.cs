using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.RecentlyPlayedGames;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response
{
    public class SteamerWebSteamLevelResponse : ISteamerWebSteamLevelResponse
    {
        public ISteamerWebRecentlyPlayedGamesRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebRecentlyPlayedGamesModel>> Model { get; init; }
    }
}