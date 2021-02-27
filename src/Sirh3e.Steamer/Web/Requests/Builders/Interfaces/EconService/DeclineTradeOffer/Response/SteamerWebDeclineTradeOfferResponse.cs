using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.DeclineTradeOffer;
using Sirh3e.Steamer.Web.Models.EconService.TradeHistory;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Response
{
    public class SteamerWebDeclineTradeOfferResponse : ISteamerWebDeclineTradeOfferResponse
    {
        public ISteamerWebTradeHistoryRequest Request { get; init; }
        public Option<SteamerWebDeclineTradeOfferModel> Model { get; init; }
    }
}