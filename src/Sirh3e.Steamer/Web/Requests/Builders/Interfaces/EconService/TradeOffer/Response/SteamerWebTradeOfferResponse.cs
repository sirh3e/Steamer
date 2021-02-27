using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeHistory;
using Sirh3e.Steamer.Web.Models.EconService.TradeOffer;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response
{
    public class SteamerWebTradeOfferResponse : ISteamerWebTradeOfferResponse
    {
        public ISteamerWebTradeOfferRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebTradeOfferModel>> Model { get; init; }
    }
}