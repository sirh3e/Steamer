using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffersSummary
{
    public class SteamerWebTradeOffersSummaryModel
    {
        [JsonPropertyName("pending_received_count")]
        public ulong PendingReceivedCount { get; set; }

        [JsonPropertyName("new_received_count")]
        public ulong NewReceivedCount { get; set; }

        [JsonPropertyName("updated_received_count")]
        public ulong UpdatedReceivedCount { get; set; }

        [JsonPropertyName("historical_received_count")]
        public ulong HistoricalReceivedCount { get; set; }

        [JsonPropertyName("pending_sent_count")]
        public ulong PendingSentCount { get; set; }

        [JsonPropertyName("newly_accepted_sent_count")]
        public ulong NewlyAcceptedSentCount { get; set; }

        [JsonPropertyName("updated_sent_count")]
        public ulong UpdatedSentCount { get; set; }

        [JsonPropertyName("historical_sent_count")]
        public long HistoricalSentCount { get; set; }

        [JsonPropertyName("escrow_received_count")]
        public long EscrowReceivedCount { get; set; }

        [JsonPropertyName("escrow_sent_count")]
        public ulong EscrowSentCount { get; set; }
    }
}