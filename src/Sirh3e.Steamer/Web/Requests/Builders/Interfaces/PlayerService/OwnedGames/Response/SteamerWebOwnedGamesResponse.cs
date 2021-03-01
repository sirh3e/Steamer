using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.OwnedGames;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Response
{
    public class SteamerWebOwnedGamesResponse : ISteamerWebOwnedGamesResponse
    {
        public ISteamerWebOwnedGamesRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebOwnedGamesModel>> Model { get; init; }
    }
}