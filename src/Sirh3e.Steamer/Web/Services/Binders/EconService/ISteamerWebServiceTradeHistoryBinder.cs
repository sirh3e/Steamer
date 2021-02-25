using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;

namespace Sirh3e.Steamer.Web.Services.Binders.EconService
{
    public interface ISteamerWebServiceTradeHistoryBinder
        : ISteamerServiceBinder<ISteamerWebTradeHistoryRequest, ISteamerWebTradeHistoryResponse>
    {
    }
}