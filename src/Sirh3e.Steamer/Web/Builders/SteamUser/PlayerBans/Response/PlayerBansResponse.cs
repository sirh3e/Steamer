using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Models.SteamUser;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans.Response
{
    public class PlayerBansResponse : IPlayerBansResponse
    {
        public IPlayerBansRequest Request { get; set; }
        public Option<PlayerBansModel> Model { get; set; }
    }
}