using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request
{
    public interface ISteamerWebTradeHistoryRequestBuilder : ISteamerRequestBuilder<ISteamerWebTradeHistoryRequest>
    {
        public ISteamerWebTradeHistoryRequestBuilder SetKey(string key);
        public ISteamerWebTradeHistoryRequestBuilder SetMaxTrades(uint maxTrades);
        public ISteamerWebTradeHistoryRequestBuilder SetStartAfterTime(uint startAfterTime);
        public ISteamerWebTradeHistoryRequestBuilder SetStartAfterTradeId(ulong startAfterTradeId);
        public ISteamerWebTradeHistoryRequestBuilder SetNavigatingBack(bool navigatingBack);
        public ISteamerWebTradeHistoryRequestBuilder SetGetDescriptions(bool getDescriptions);
        public ISteamerWebTradeHistoryRequestBuilder SetLanguage(string language);
        public ISteamerWebTradeHistoryRequestBuilder SetIncludeFailed(bool includeFailed);

        public ISteamerWebTradeHistoryRequestBuilder SetIncludeTotal(bool includeTotal);
        /*
        new SteamerU32Parameter("max_trades"),
        new SteamerU32Parameter("start_after_time"),
        new SteamerU64Parameter("start_after_tradeid"),
        new SteamerBooleanParameter("navigating_back"),
        new SteamerBooleanParameter("get_descriptions"),
        new SteamerStringParameter("language"),
        new SteamerBooleanParameter("include_failed"),
        new SteamerBooleanParameter("include_total")
        */
    }
}