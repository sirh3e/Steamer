using System;
using Sirh3e.Steamer.Web.Extensions.EconService.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.EconService.Response
{
    public static class SteamerWebTradeOffersSummaryResponseExtension
    {
        public static ISteamerWebTradeOffersSummaryResponse RetryServiceExecute(this ISteamerWebTradeOffersSummaryResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        } 
    }
}