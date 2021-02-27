using System;
using Sirh3e.Steamer.Web.Extensions.EconService.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.EconService.Response
{
    public static class SteamerWebTradeOfferResponseExtension
    {
        public static ISteamerWebTradeOfferResponse RetryServiceExecute(this ISteamerWebTradeOfferResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ServiceExecute(service);
        }
    }
}