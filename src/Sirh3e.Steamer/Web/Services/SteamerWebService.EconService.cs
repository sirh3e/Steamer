using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService
    {
        public ISteamerWebTradeHistoryResponse Execute(ISteamerWebTradeHistoryRequest request)
        {
            var response = new SteamerWebTradeHistoryResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebTradeOfferResponse Execute(ISteamerWebTradeOfferRequest request)
        {
            var response = new SteamerWebTradeOfferResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebTradeOffersResponse Execute(ISteamerWebTradeOffersRequest request)
        {
            var response = new SteamerWebTradeOffersResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}