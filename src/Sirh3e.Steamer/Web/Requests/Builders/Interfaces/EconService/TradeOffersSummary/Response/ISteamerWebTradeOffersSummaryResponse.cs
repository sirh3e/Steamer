using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeOffer;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Response
{
    public interface ISteamerWebTradeOffersSummaryResponse : ISteamerResponse<ISteamerWebTradeOffersSummaryRequest,
        SteamerWebResponseModel<SteamerWebTradeOffersSummaryModel>>
    {
    }
}