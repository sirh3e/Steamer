using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffer.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService
{
    public interface ISteamerWebEconServiceInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebTradeHistoryRequestBuilder TradeHistory { get; }
        public ISteamerWebTradeOfferRequestBuilder TradeOffer { get; }
    }
}