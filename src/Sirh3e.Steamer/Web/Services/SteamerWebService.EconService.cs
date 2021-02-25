using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService
    {
        public ISteamerWebTradeHistoryResponse Execute(ISteamerWebTradeHistoryRequest request)
        {
            var response = new SteamerWebTradeHistoryResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}