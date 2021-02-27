using System;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request
{
    public class SteamerWebTradeOffersRequest : SteamerRequest, ISteamerWebTradeOffersRequest
    {
        public SteamerWebTradeOffersRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(),
            "GetTradeOffers", 1,
            new SteamerParameters(new SteamerStringParameter("key"),
                new SteamerBooleanParameter("get_sent_offers"),
                new SteamerBooleanParameter("get_received_offers"),
                new SteamerBooleanParameter("get_descriptions"),
                new SteamerStringParameter("language", false),
                new SteamerBooleanParameter("active_only", false),
                new SteamerBooleanParameter("historical_only", false),
                new SteamerDateTimeParameter("time_historical_cutoff", DateTime.Now, false)
            ))){}
    }
}