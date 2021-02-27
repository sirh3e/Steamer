using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.CancelTradeOffer
{
    public class SteamerWebCancelTradeOfferModel
    {
        [JsonPropertyName("response")]
        public object Response { get; set; }
    }
}