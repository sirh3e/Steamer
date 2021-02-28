using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.EconService.CancelTradeOffer;
using Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Response
{
    public class SteamerWebUserStatsForGameResponse : ISteamerWebUserStatsForGameResponse
    {
        public ISteamerWebUserStatsForGameRequest Request { get; init; }
        public Option<SteamerWebUserStatsForGameModel> Model { get; init; }
    }
}