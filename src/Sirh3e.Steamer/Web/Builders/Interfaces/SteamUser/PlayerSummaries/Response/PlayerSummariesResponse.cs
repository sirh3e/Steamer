using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Response
{
    public class PlayerSummariesResponse : IPlayerSummariesResponse
    {
        public IPlayerSummariesRequest Request { get; init; }
        public Option<ResponseModel<PlayerSummariesModel>> Model { get; init; }
    }
}