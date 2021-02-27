using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Response;

namespace Sirh3e.Steamer.Web.Services.Binders.EconService
{
    public interface ISteamerWebServiceCancelTradeOfferBinder
        : ISteamerServiceBinder<ISteamerWebCancelTradeOfferRequest, ISteamerWebCancelTradeOfferResponse>
    {

    }
}