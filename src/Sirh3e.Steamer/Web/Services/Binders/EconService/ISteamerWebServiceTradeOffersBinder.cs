using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Response;

namespace Sirh3e.Steamer.Web.Services.Binders.EconService
{
    public interface ISteamerWebServiceTradeOffersBinder
        : ISteamerServiceBinder<ISteamerWebTradeOffersRequest, ISteamerWebTradeOffersResponse>
    {

    }
}