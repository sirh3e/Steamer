using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.EconService.Request
{
    public static class SteamerWebDeclineTradeOfferRequestExtension
    {
        public static ISteamerWebDeclineTradeOfferResponse ServiceExecute(this ISteamerWebDeclineTradeOfferRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}