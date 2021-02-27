using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffers
{
    public class SteamerWebTradeOffersActionModel
    {
        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}