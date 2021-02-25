using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeHistory
{
    public class SteamerWebTradeModel
    {
        [JsonPropertyName("tradeid")]
        public string TradeId { get; set; }

        [JsonPropertyName("steamid_other")]
        public string SteamIdOther { get; set; }

        [JsonPropertyName("time_init")]
        public long TimeInit { get; set; }

        [JsonPropertyName("status")]
        public long Status { get; set; }

        [JsonPropertyName("assets_received")] //ToDo add default value for null handling
        public List<SteamerWebAssetsModel>? AssetsReceived { get; set; }

        [JsonPropertyName("time_escrow_end")]
        public long? TimeEscrowEnd { get; set; }

        [JsonPropertyName("assets_given")]
        public List<SteamerWebAssetsModel>? AssetsGiven { get; set; }
    }
}