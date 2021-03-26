using System;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request
{
    public class SteamerWebTradeOffersSummaryRequest
        : SteamerRequest, ISteamerWebTradeOffersSummaryRequest
    {
        public SteamerWebTradeOffersSummaryRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(),
            "GetTradeOffersSummary", 1,
            new SteamerParameters(new SteamerStringParameter("key"),
                new SteamerDateTimeParameter("time_last_visit", DateTime.Now))))
        {
        }
    }
}