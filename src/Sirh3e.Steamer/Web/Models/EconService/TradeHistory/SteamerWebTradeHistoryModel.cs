using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeHistory
{
    public class SteamerWebTradeHistoryModel
    {
        [JsonPropertyName("total_trades")]
        public ulong TotalTrades { get; set; }

        [JsonPropertyName("more")]
        public bool More { get; set; }

        [JsonPropertyName("trades")]
        public List<SteamerWebTradeHistoryTradeModel> Trades { get; set; } = new();
    }
}