using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request
{
    public interface ISteamerWebCancelTradeOfferRequestBuilder : ISteamerRequestBuilder<ISteamerWebCancelTradeOfferRequest>
    {
        public ISteamerWebCancelTradeOfferRequestBuilder SetKey(string key);
        public ISteamerWebCancelTradeOfferRequestBuilder SetTradeOfferId(ulong tradeOfferId);
    }
}