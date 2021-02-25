using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeHistory
{
    public class SteamerWebTradeHistoryModel
    {
        [JsonPropertyName("more")]
        public bool More { get; set; }

        [JsonPropertyName("trades")]
        public List<SteamerWebTradeModel> Trades { get; set; } = new();
    }
}