using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request
{
    public class SteamerWebDeclineTradeOfferRequestBuilder
        : SteamerRequestBuilder<SteamerWebDeclineTradeOfferRequestBuilder, ISteamerWebDeclineTradeOfferRequest>,
            ISteamerWebDeclineTradeOfferRequestBuilder
    {
        public SteamerWebDeclineTradeOfferRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new SteamerWebDeclineTradeOfferRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));
        }

        public override ISteamerWebDeclineTradeOfferRequest Build()
        {
            var request = Request;

            Request = new SteamerWebDeclineTradeOfferRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebDeclineTradeOfferRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebDeclineTradeOfferRequestBuilder SetTradeOfferId(ulong tradeOfferId)
            => SetValue("tradeofferid", tradeOfferId);
    }
}