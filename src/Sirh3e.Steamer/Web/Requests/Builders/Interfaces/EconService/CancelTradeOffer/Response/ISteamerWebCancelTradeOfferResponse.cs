using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.EconService.CancelTradeOffer;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Response
{
    public interface ISteamerWebCancelTradeOfferResponse : ISteamerResponse<ISteamerWebCancelTradeOfferRequest,
        SteamerWebCancelTradeOfferModel>
    {
    }
}