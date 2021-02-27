using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request
{
    public class SteamerWebTradeOffersRequestBuilder : SteamerRequestBuilder<SteamerWebTradeOffersRequestBuilder,
                                                           ISteamerWebTradeOffersRequest>,
                                                       ISteamerWebTradeOffersRequestBuilder
    {
        public SteamerWebTradeOffersRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebTradeOffersRequest(Interface ??
                                                       throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebTradeOffersRequest Build()
        {
            var request = Request;

            Request = new SteamerWebTradeOffersRequest(Interface ??
                                                       throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebTradeOffersRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebTradeOffersRequestBuilder SetGetSentOffers(bool getSentOffers)
            => SetValue("get_sent_offers", getSentOffers);

        public ISteamerWebTradeOffersRequestBuilder SetGetReceivedOffers(bool getReceivedOffers)
            => SetValue("get_received_offers", getReceivedOffers);

        public ISteamerWebTradeOffersRequestBuilder SetGetDescriptions(bool getDescriptions)
            => SetValue("get_descriptions", getDescriptions);


        public ISteamerWebTradeOffersRequestBuilder SetLanguage(string language)
            => SetValue("language", language);

        public ISteamerWebTradeOffersRequestBuilder SetActiveOnly(bool activeOnly)
            => SetValue("active_only", activeOnly);

        public ISteamerWebTradeOffersRequestBuilder SetHistoricalOnly(bool historicalOnly)
            => SetValue("historical_only", historicalOnly);
    }
}