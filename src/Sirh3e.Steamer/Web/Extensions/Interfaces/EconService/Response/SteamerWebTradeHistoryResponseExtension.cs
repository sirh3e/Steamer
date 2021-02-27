using System;
using Sirh3e.Steamer.Web.Extensions.Interfaces.EconService.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.EconService.Response
{
    public static class SteamerWebTradeHistoryResponseExtension
    {
        public static ISteamerWebTradeHistoryResponse RetryServiceExecute(this ISteamerWebTradeHistoryResponse response,
                                                                          ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}