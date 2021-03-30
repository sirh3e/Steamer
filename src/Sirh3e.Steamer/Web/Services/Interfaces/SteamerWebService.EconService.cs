using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public Task<Result<ISteamerWebCancelTradeOfferResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebCancelTradeOfferRequest request)
        {
            var response = new SteamerWebCancelTradeOfferResponse();

            return MapAsync<SteamerWebCancelTradeOfferResponse, ISteamerWebCancelTradeOfferResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebDeclineTradeOfferResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebDeclineTradeOfferRequest request)
        {
            var response = new SteamerWebDeclineTradeOfferResponse();

            return MapAsync<SteamerWebDeclineTradeOfferResponse, ISteamerWebDeclineTradeOfferResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebTradeHistoryResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebTradeHistoryRequest request)
        {
            var response = new SteamerWebTradeHistoryResponse();

            return MapAsync<SteamerWebTradeHistoryResponse, ISteamerWebTradeHistoryResponse>(ExecuteAsync(request,
                response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebTradeOfferResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebTradeOfferRequest request)
        {
            var response = new SteamerWebTradeOfferResponse();

            return MapAsync<SteamerWebTradeOfferResponse, ISteamerWebTradeOfferResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebTradeOffersResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebTradeOffersRequest request)
        {
            var response = new SteamerWebTradeOffersResponse();

            return MapAsync<SteamerWebTradeOffersResponse, ISteamerWebTradeOffersResponse>(ExecuteAsync(request,
                response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebTradeOffersSummaryResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebTradeOffersSummaryRequest request)
        {
            var response = new SteamerWebTradeOffersSummaryResponse();

            return MapAsync<SteamerWebTradeOffersSummaryResponse, ISteamerWebTradeOffersSummaryResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }
    }
}