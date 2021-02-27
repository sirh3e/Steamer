using System;
using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request
{
    public interface ISteamerWebTradeOffersSummaryRequestBuilder : ISteamerRequestBuilder<ISteamerWebTradeOffersSummaryRequest>
    {
        public ISteamerWebTradeOffersSummaryRequestBuilder SetKey(string key);
        public ISteamerWebTradeOffersSummaryRequestBuilder SetTimeLastVisit(DateTime timeLastVisit);
    }
}