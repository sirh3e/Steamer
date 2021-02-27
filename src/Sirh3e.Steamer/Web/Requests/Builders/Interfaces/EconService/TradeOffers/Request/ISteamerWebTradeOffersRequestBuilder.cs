using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request
{
    public interface ISteamerWebTradeOffersRequestBuilder : ISteamerRequestBuilder<ISteamerWebTradeOffersRequest>
    {
        public ISteamerWebTradeOffersRequestBuilder SetKey(string key);
        public ISteamerWebTradeOffersRequestBuilder SetGetSentOffers(bool getSentOffers);
        public ISteamerWebTradeOffersRequestBuilder SetGetReceivedOffers(bool getReceivedOffers);
        public ISteamerWebTradeOffersRequestBuilder SetGetDescriptions(bool getDescriptions);
        public ISteamerWebTradeOffersRequestBuilder SetLanguage(string language);
        public ISteamerWebTradeOffersRequestBuilder SetActiveOnly(bool activeOnly);
        public ISteamerWebTradeOffersRequestBuilder SetHistoricalOnly(bool historicalOnly);
    }
}