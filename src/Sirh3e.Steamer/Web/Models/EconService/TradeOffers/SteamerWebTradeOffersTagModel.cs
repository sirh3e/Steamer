using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffers
{
    public class SteamerWebTradeOffersTagModel
    {
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("internal_name")]
        public string InternalName { get; set; }

        [JsonPropertyName("localized_category_name")]
        public string LocalizedCategoryName { get; set; }

        [JsonPropertyName("localized_tag_name")]
        public string LocalizedTagName { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }
    }
}