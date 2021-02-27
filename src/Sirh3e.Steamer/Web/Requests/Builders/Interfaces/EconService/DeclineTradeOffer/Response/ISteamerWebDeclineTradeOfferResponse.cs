using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.DeclineTradeOffer;
using Sirh3e.Steamer.Web.Models.EconService.TradeHistory;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Response
{
    public interface ISteamerWebDeclineTradeOfferResponse : ISteamerResponse<ISteamerWebTradeHistoryRequest,
        SteamerWebDeclineTradeOfferModel>
    {
    }
}