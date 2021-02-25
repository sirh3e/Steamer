using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request
{
    public class SteamerWebTradeHistoryRequestBuilder : SteamerRequestBuilder<SteamerWebTradeHistoryRequestBuilder,
                                                            ISteamerWebTradeHistoryRequest>,
                                                        ISteamerWebTradeHistoryRequestBuilder
    {
        public SteamerWebTradeHistoryRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebTradeHistoryRequest(Interface ??
                                                        throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebTradeHistoryRequest Build()
        {
            var request = Request;

            Request = new SteamerWebTradeHistoryRequest(Interface ??
                                                        throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebTradeHistoryRequestBuilder SetKey(string key) => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebTradeHistoryRequestBuilder SetMaxTrades(uint maxTrades) => SetValue("max_trades", maxTrades);

        public ISteamerWebTradeHistoryRequestBuilder SetStartAfterTime(uint startAfterTime) => SetValue("start_after_time", startAfterTime);

        public ISteamerWebTradeHistoryRequestBuilder SetStartAfterTradeId(ulong startAfterTradeId) =>
            SetValue("start_after_tradeid", startAfterTradeId);

        public ISteamerWebTradeHistoryRequestBuilder SetNavigatingBack(bool navigatingBack) => SetValue("navigating_back", navigatingBack);

        public ISteamerWebTradeHistoryRequestBuilder SetGetDescriptions(bool getDescriptions) => SetValue("get_descriptions", getDescriptions);

        public ISteamerWebTradeHistoryRequestBuilder SetLanguage(string language) =>
            SetValue("language", language ?? throw new ArgumentNullException(nameof(language)));

        public ISteamerWebTradeHistoryRequestBuilder SetIncludeFailed(bool includeFailed) => SetValue("include_failed", includeFailed);

        public ISteamerWebTradeHistoryRequestBuilder SetIncludeTotal(bool includeTotal) => SetValue("include_total", includeTotal);
    }
}