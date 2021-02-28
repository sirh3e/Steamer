using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.EconService.DeclineTradeOffer;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Response
{
    public class SteamerWebDeclineTradeOfferResponse : ISteamerWebDeclineTradeOfferResponse
    {
        public ISteamerWebDeclineTradeOfferRequest Request { get; init; }
        public Option<SteamerWebDeclineTradeOfferModel> Model { get; init; }
    }
}