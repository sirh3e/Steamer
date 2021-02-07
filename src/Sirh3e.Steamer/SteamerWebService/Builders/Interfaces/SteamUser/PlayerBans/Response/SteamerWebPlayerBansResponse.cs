using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Models.PlayerBans;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Response
{
    public class SteamerWebPlayerBansResponse : ISteamerWebPlayerBansResponse
    {
        public ISteamerWebPlayerBansRequest Request { get; init; }
        public Option<SteamerWebPlayerBansModel> Model { get; init; }
    }
}