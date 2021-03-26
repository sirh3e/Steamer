using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request
{
    public class SteamerWebTradeOffersSummaryRequestBuilder
        : SteamerRequestBuilder<SteamerWebTradeOffersSummaryRequestBuilder, ISteamerWebTradeOffersSummaryRequest>,
            ISteamerWebTradeOffersSummaryRequestBuilder
    {
        public SteamerWebTradeOffersSummaryRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebTradeOffersSummaryRequest(Interface ??
                                                              throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebTradeOffersSummaryRequest Build()
        {
            var request = Request;

            Request = new SteamerWebTradeOffersSummaryRequest(Interface ??
                                                              throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebTradeOffersSummaryRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebTradeOffersSummaryRequestBuilder SetTimeLastVisit(DateTime timeLastVisit)
            => SetValue("time_last_visit", timeLastVisit);
    }
}