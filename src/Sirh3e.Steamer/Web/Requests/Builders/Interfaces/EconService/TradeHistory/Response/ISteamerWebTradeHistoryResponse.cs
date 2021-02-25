using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeHistory;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response
{
    public interface ISteamerWebTradeHistoryResponse : ISteamerResponse<ISteamerWebTradeHistoryRequest,
        SteamerWebResponseModel<SteamerWebTradeHistoryModel>>
    {
    }
}