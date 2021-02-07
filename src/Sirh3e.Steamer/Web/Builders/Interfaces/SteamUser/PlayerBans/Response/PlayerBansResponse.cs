using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Models.PlayerBans;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Response
{
    public class PlayerBansResponse : IPlayerBansResponse
    {
        public IPlayerBansRequest Request { get; init; }
        public Option<PlayerBansModel> Model { get; init; }
    }
}