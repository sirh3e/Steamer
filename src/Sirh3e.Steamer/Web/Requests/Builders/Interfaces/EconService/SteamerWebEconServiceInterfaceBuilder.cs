using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService
{
    public class SteamerWebEconServiceInterfaceBuilder : SteamerInterface, ISteamerWebEconServiceInterfaceBuilder
    {
        public SteamerWebEconServiceInterfaceBuilder() : base("IEconService") => TradeHistory = new SteamerWebTradeHistoryRequestBuilder(this);

        public ISteamerWebTradeHistoryRequestBuilder TradeHistory { get; }
    }
}