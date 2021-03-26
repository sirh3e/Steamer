using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request
{
    public class SteamerWebTradeHistoryRequest : SteamerRequest, ISteamerWebTradeHistoryRequest
    {
        public SteamerWebTradeHistoryRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(),
            "GetTradeHistory", 1,
            new SteamerParameters(new SteamerStringParameter("key"),
                new SteamerU32Parameter("max_trades"),
                new SteamerU32Parameter("start_after_time"),
                new SteamerU64Parameter("start_after_tradeid"),
                new SteamerBooleanParameter("navigating_back"),
                new SteamerBooleanParameter("get_descriptions"),
                new SteamerStringParameter("language"),
                new SteamerBooleanParameter("include_failed"),
                new SteamerBooleanParameter("include_total"))))
        {
        }
    }
}