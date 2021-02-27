using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeOffers;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Response
{
    public class SteamerWebTradeOffersResponse : ISteamerWebTradeOffersResponse
    {
        public ISteamerWebTradeOfferRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebTradeOffersModel>> Model { get; init; }
    }
}