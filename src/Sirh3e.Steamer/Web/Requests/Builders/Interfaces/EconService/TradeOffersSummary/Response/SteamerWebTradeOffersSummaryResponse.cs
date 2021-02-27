using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeOffersSummary;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Response
{
    public class SteamerWebTradeOffersSummaryResponse : ISteamerWebTradeOffersSummaryResponse
    {
        public ISteamerWebTradeOffersSummaryRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebTradeOffersSummaryModel>> Model { get; init; }
    }
}