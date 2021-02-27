using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffers
{
    public class SteamerWebTradeOffersModel
    {
        [JsonPropertyName("trade_offers_sent")]
        public List<SteamerWebTradeOffersSendModel> TradeOffersSent { get; set; } = new();

        [JsonPropertyName("trade_offers_received")]
        public List<SteamerWebTradeOffersReceivedModel> TradeOffersReceived { get; set; } = new();

        [JsonPropertyName("descriptions")]
        public List<SteamerWebTradeOffersDescriptionModel> Descriptions { get; set; } = new();
    }
}