using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request
{
    public class SteamerWebCancelTradeOfferRequestBuilder : SteamerRequestBuilder<SteamerWebCancelTradeOfferRequestBuilder,
                                                                 ISteamerWebCancelTradeOfferRequest>,
                                                             ISteamerWebCancelTradeOfferRequestBuilder
    {
        public SteamerWebCancelTradeOfferRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebCancelTradeOfferRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebCancelTradeOfferRequest Build()
        {
            var request = Request;

            Request = new SteamerWebCancelTradeOfferRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebCancelTradeOfferRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebCancelTradeOfferRequestBuilder SetTradeOfferId(ulong tradeOfferId)
            => SetValue("tradeofferid", tradeOfferId);
    }
}