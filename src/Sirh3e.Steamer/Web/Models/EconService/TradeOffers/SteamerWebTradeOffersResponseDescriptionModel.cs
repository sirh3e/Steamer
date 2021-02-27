using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffers
{
    public class SteamerWebTradeOffersResponseDescriptionModel
    {
        [JsonPropertyName("appid")]
        public ulong AppId { get; set; }

        [JsonPropertyName("classid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong ClassId { get; set; }

        [JsonPropertyName("instanceid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong InstanceId { get; set; }

        [JsonPropertyName("currency")]
        public bool Currency { get; set; }

        [JsonPropertyName("background_color")]
        public string BackgroundColor { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("icon_url_large")]
        public string IconUrlLarge { get; set; }

        [JsonPropertyName("descriptions")]
        public List<SteamerWebTradeOffersDescriptionModel> Descriptions { get; set; }

        [JsonPropertyName("tradable")]
        public bool Tradable { get; set; }

        [JsonPropertyName("owner_actions")]
        public List<SteamerWebTradeOffersActionModel>? OwnerActions { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("market_name")]
        public string MarketName { get; set; }

        [JsonPropertyName("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonPropertyName("market_fee_app")]
        public ulong? MarketFeeApp { get; set; }

        [JsonPropertyName("commodity")]
        public bool Commodity { get; set; }

        [JsonPropertyName("market_tradable_restriction")]
        public ulong MarketTradableRestriction { get; set; }

        [JsonPropertyName("market_marketable_restriction")]
        public ulong? MarketMarketableRestriction { get; set; }

        [JsonPropertyName("marketable")]
        public bool Marketable { get; set; }

        [JsonPropertyName("tags")]
        public List<SteamerWebTradeOffersTagModel> Tags { get; set; } = new();

        [JsonPropertyName("name_color")]
        public string? NameColor { get; set; }

        [JsonPropertyName("actions")]
        public List<SteamerWebTradeOffersActionModel>? Actions { get; set; }

        [JsonPropertyName("market_actions")]
        public List<SteamerWebTradeOffersActionModel>? MarketActions { get; set; }
    }
}