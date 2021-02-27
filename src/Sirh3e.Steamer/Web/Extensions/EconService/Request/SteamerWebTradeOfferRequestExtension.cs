using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.EconService.Request
{
    public static class SteamerWebTradeOfferRequestExtension
    {
        public static ISteamerWebTradeOfferResponse ServiceExecute(this ISteamerWebTradeOfferRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}