using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeHistory
{
    public class SteamerWebTradeModel
    {
        [JsonPropertyName("tradeid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong TradeId { get; set; }

        [JsonPropertyName("steamid_other")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong SteamIdOther { get; set; }

        [JsonPropertyName("time_init")]
        public ulong TimeInit { get; set; }

        [JsonPropertyName("status")]
        public ulong Status { get; set; }

        [JsonPropertyName("assets_received")] //ToDo add default value for null handling
        public List<SteamerWebAssetsModel>? AssetsReceived { get; set; }

        [JsonPropertyName("time_escrow_end")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong? TimeEscrowEnd { get; set; }

        [JsonPropertyName("assets_given")]
        public List<SteamerWebAssetsModel>? AssetsGiven { get; set; }
    }
}