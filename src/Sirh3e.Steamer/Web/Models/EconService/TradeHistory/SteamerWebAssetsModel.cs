using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeHistory
{
    public class SteamerWebAssetsModel
    {
        [JsonPropertyName("appid")]
        public long Appid { get; set; }

        [JsonPropertyName("contextid")]
        //[JsonConverter(typeof(Converters.ParseStringConverter))]
        public string ContextId { get; set; }

        [JsonPropertyName("assetid")]
        public string AssetId { get; set; }

        [JsonPropertyName("amount")]
        //[JsonConverter(typeof(Converters.ParseStringConverter))]
        public string Amount { get; set; }

        [JsonPropertyName("classid")]
        //[JsonConverter(typeof(Converters.ParseStringConverter))]
        public string ClassId { get; set; }

        [JsonPropertyName("instanceid")]
        //[JsonConverter(typeof(Converters.ParseStringConverter))]
        public string InstanceId { get; set; }

        [JsonPropertyName("new_assetid")]
        public string NewAssetId { get; set; }

        [JsonPropertyName("new_contextid")]
        //[JsonConverter(typeof(Converters.ParseStringConverter))]
        public string NewContextId { get; set; }
    }
}