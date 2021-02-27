using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService
{
    public interface ISteamerWebEconServiceInterfaceBuilder : ISteamerInterface
    {
    public ISteamerWebCancelTradeOfferRequestBuilder CancelTradeOffer { get; }
        public ISteamerWebDeclineTradeOfferRequestBuilder DeclineTradeOffer { get; }
        public ISteamerWebTradeHistoryRequestBuilder TradeHistory { get; }
        public ISteamerWebTradeOfferRequestBuilder TradeOffer { get; }
        public ISteamerWebTradeOffersRequestBuilder TradeOffers { get; }
        public ISteamerWebTradeOffersSummaryRequestBuilder TradeOffersSummary { get; }
    }
}