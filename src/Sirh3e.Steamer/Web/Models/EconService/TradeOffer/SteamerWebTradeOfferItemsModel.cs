using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffer
{
    public class SteamerWebTradeOfferItems
    {
        [JsonPropertyName("appid")]
        public ulong AppId { get; set; }

        [JsonPropertyName("contextid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong ContextId { get; set; }

        [JsonPropertyName("assetid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong AssetId { get; set; }

        [JsonPropertyName("classid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong ClassId { get; set; }

        [JsonPropertyName("instanceid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong InstanceId { get; set; }

        [JsonPropertyName("amount")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong Amount { get; set; }

        [JsonPropertyName("missing")]
        public bool Missing { get; set; }

        [JsonPropertyName("est_usd")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong EstUsd { get; set; }
    }
}