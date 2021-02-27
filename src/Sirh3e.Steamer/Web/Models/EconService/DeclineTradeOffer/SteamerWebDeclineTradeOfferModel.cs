using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.DeclineTradeOffer
{
    public class SteamerWebDeclineTradeOfferModel
    {
        [JsonPropertyName("response")]
        public object Response { get; set; } 
    }
}