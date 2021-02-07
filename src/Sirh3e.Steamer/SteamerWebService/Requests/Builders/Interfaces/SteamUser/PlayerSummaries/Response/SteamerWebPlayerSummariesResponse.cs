using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.PlayerSummaries;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response
{
    public class SteamerWebPlayerSummariesResponse : ISteamerWebPlayerSummariesResponse
    {
        public ISteamerWebPlayerSummariesRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebPlayerSummariesModel>> Model { get; init; }
    }
}