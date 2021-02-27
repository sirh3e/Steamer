using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.CancelTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService
{
    public class SteamerWebEconServiceInterfaceBuilder : SteamerInterface, ISteamerWebEconServiceInterfaceBuilder
    {
        public SteamerWebEconServiceInterfaceBuilder() : base("IEconService")
        {
            CancelTradeOffer = new SteamerWebCancelTradeOfferRequestBuilder(this);
            DeclineTradeOffer = new SteamerWebDeclineTradeOfferRequestBuilder(this);
            TradeHistory = new SteamerWebTradeHistoryRequestBuilder(this);
            TradeOffer = new SteamerWebTradeOfferRequestBuilder(this);
            TradeOffers = new SteamerWebTradeOffersRequestBuilder(this);
            TradeOffersSummary = new SteamerWebTradeOffersSummaryRequestBuilder(this);
        }

        public ISteamerWebCancelTradeOfferRequestBuilder CancelTradeOffer { get; }
        public ISteamerWebDeclineTradeOfferRequestBuilder DeclineTradeOffer { get; }
        public ISteamerWebTradeHistoryRequestBuilder TradeHistory { get; }
        public ISteamerWebTradeOfferRequestBuilder TradeOffer { get; }
        public ISteamerWebTradeOffersRequestBuilder TradeOffers { get; }
        public ISteamerWebTradeOffersSummaryRequestBuilder TradeOffersSummary { get; }
    }
}