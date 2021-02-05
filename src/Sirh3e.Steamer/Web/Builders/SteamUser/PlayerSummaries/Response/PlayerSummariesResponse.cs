using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Response
{
    public class PlayerSummariesResponse : IPlayerSummariesResponse
    {
        public IPlayerSummariesRequest Request { get; set; }
        public Option<ResponseModel<PlayerSummariesModel>> Model { get; set; }
    }
}