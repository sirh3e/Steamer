using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamUserStats.NumberOfCurrentPlayers;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Response
{
    public class SteamerWebNumberOfCurrentPlayersResponse : ISteamerWebNumberOfCurrentPlayersResponse
    {
        public ISteamerWebNumberOfCurrentPlayersRequest Request { get; init; }
        public Option<SteamerWebNumberOfCurrentPlayersModel> Model { get; init; }
    }
}