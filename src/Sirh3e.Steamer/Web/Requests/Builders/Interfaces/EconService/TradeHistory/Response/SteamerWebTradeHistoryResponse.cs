using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeHistory;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeHistory.Response
{
    public class SteamerWebTradeHistoryResponse : ISteamerWebTradeHistoryResponse
    {
        public ISteamerWebTradeHistoryRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebTradeHistoryModel>> Model { get; init; }
    }
}