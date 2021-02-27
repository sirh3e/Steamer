using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response;

namespace Sirh3e.Steamer.Web.Services.EconService.Binders
{
    public interface ISteamerWebServiceTradeOfferBinder
        : ISteamerServiceBinder<ISteamerWebTradeOfferRequest, ISteamerWebTradeOfferResponse>
    {
    }
}