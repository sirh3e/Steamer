using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffer
{
    public class SteamerWebTradeOfferModel
    {
        [JsonPropertyName("offer")]
        public SteamerWebOfferModel Offer { get; set; }
    }
}