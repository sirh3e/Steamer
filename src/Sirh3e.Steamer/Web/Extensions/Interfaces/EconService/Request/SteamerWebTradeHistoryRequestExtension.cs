using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.EconService.Request
{
    public static class SteamerWebTradeHistoryRequestExtension
    {
        public static Task<Result<ISteamerWebTradeHistoryResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebTradeHistoryRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}