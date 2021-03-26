using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request
{
    public interface
        ISteamerWebDeclineTradeOfferRequestBuilder : ISteamerRequestBuilder<ISteamerWebDeclineTradeOfferRequest>
    {
        public ISteamerWebDeclineTradeOfferRequestBuilder SetKey(string key);
        public ISteamerWebDeclineTradeOfferRequestBuilder SetTradeOfferId(ulong tradeOfferId);
    }
}