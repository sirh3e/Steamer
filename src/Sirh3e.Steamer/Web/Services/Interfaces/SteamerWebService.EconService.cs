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
        public ISteamerWebCancelTradeOfferResponse Execute(ISteamerWebCancelTradeOfferRequest request)
        {
            var response = new SteamerWebCancelTradeOfferResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebDeclineTradeOfferResponse Execute(ISteamerWebDeclineTradeOfferRequest request)
        {
            var response = new SteamerWebDeclineTradeOfferResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebTradeHistoryResponse Execute(ISteamerWebTradeHistoryRequest request)
        {
            var response = new SteamerWebTradeHistoryResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebTradeOfferResponse Execute(ISteamerWebTradeOfferRequest request)
        {
            var response = new SteamerWebTradeOfferResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebTradeOffersResponse Execute(ISteamerWebTradeOffersRequest request)
        {
            var response = new SteamerWebTradeOffersResponse();

            return Execute(request, response, response.Model.Unwrap);
        }

        public ISteamerWebTradeOffersSummaryResponse Execute(ISteamerWebTradeOffersSummaryRequest request)
        {
            var response = new SteamerWebTradeOffersSummaryResponse();

            return Execute(request, response, response.Model.Unwrap);
        }
    }
}