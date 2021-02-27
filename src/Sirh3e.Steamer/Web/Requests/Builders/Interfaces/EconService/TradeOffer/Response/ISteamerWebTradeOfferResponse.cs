using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeOffer;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response
{
    public interface ISteamerWebTradeOfferResponse : ISteamerResponse<ISteamerWebTradeOfferRequest,
        SteamerWebResponseModel<SteamerWebTradeOfferModel>>
    {
    }
}