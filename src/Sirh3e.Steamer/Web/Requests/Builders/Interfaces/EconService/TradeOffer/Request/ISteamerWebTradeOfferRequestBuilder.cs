using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request
{
    public interface ISteamerWebTradeOfferRequestBuilder : ISteamerRequestBuilder<ISteamerWebTradeOfferRequest>
    {
        public ISteamerWebTradeOfferRequestBuilder SetKey(string key);
        public ISteamerWebTradeOfferRequestBuilder SetTradeOfferId(ulong tradeOfferId);
        public ISteamerWebTradeOfferRequestBuilder SetLanguage(string language);
    }
}