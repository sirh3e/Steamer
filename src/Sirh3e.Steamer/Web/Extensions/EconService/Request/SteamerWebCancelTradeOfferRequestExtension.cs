using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.EconService.Request
{
    public static class SteamerWebCancelTradeOfferRequestExtension
    {
        public static ISteamerWebCancelTradeOfferResponse ServiceExecute(this ISteamerWebCancelTradeOfferRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}