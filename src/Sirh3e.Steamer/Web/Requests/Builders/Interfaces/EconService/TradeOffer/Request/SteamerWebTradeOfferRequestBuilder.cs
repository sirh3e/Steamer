using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request
{
    public class SteamerWebTradeOfferRequestBuilder
        : SteamerRequestBuilder<SteamerWebTradeOfferRequestBuilder, ISteamerWebTradeOfferRequest>,
            ISteamerWebTradeOfferRequestBuilder
    {
        public SteamerWebTradeOfferRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebTradeOfferRequest(Interface ??
                                                        throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebTradeOfferRequest Build()
        {
            var request = Request;

            Request = new SteamerWebTradeOfferRequest(Interface ??
                                                        throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebTradeOfferRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebTradeOfferRequestBuilder SetTradeOfferId(ulong tradeOfferId)
            => SetValue("tradeofferid", tradeOfferId);

        public ISteamerWebTradeOfferRequestBuilder SetLanguage(string language)
            => SetValue("language", language ?? throw new ArgumentNullException(nameof(language)));
    }
}