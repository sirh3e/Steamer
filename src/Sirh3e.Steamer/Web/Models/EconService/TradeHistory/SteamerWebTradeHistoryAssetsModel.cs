using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeHistory
{
    public class SteamerWebAssetsModel
    {
        [JsonPropertyName("appid")]
        public long Appid { get; set; }

        [JsonPropertyName("contextid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong ContextId { get; set; }

        [JsonPropertyName("assetid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong AssetId { get; set; }

        [JsonPropertyName("amount")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong Amount { get; set; }

        [JsonPropertyName("classid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong ClassId { get; set; }

        [JsonPropertyName("instanceid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong InstanceId { get; set; }

        [JsonPropertyName("new_assetid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong NewAssetId { get; set; }

        [JsonPropertyName("new_contextid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong NewContextId { get; set; }
    }
}