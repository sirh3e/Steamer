using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.PlayerSummaries;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Response
{
    public class PlayerSummariesResponse : IPlayerSummariesResponse
    {
        public IPlayerSummariesRequest Request { get; init; }
        public Option<ResponseModel<PlayerSummariesModel>> Model { get; init; }
    }
}