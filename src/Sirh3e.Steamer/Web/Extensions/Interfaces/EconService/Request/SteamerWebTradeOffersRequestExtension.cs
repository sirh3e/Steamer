using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.EconService.Request
{
    public static class SteamerWebTradeOffersRequestExtension
    {
        public static Task<Result<ISteamerWebTradeOffersResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebTradeOffersRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}