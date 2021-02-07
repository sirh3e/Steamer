using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response
{
    public class SteamerWebPlayerBansResponse : ISteamerWebPlayerBansResponse
    {
        public ISteamerWebPlayerBansRequest Request { get; init; }
        public Option<SteamerWebPlayerBansModel> Model { get; init; }
    }
}