using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.EconService.CancelTradeOffer;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Response
{
    public class SteamerWebCancelTradeOfferResponse : ISteamerWebCancelTradeOfferResponse
    {
        public ISteamerWebCancelTradeOfferRequest Request { get; init; }
        public Option<SteamerWebCancelTradeOfferModel> Model { get; init; }
    }
}