﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.EconService.TradeOffer
{
    public class SteamerWebTradeOfferOfferModel
    {
        [JsonPropertyName("tradeofferid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong TradeOfferId { get; set; }

        [JsonPropertyName("accountid_other")]
        public ulong AccountIdOther { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("expiration_time")]
        public ulong ExpirationTime { get; set; }

        [JsonPropertyName("trade_offer_state")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SteamerWebEconServiceTradeOfferState TradeOfferState { get; set; }

        [JsonPropertyName("items_to_give")]
        public List<SteamerWebTradeOfferItemsModel> ItemsToGive { get; set; } = new();

        [JsonPropertyName("items_to_receive")]
        public List<SteamerWebTradeOfferItemsModel> ItemsToReceive { get; set; } = new();

        [JsonPropertyName("is_our_offer")]
        public bool IsOurOffer { get; set; }

        [JsonPropertyName("time_created")]
        public ulong TimeCreated { get; set; }

        [JsonPropertyName("time_updated")]
        public ulong TimeUpdated { get; set; }

        [JsonPropertyName("from_real_time_trade")]
        public bool FromRealTimeTrade { get; set; }

        [JsonPropertyName("escrow_end_date")]
        public ulong EscrowEndDate { get; set; }

        [JsonPropertyName("confirmation_method")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SteamerWebEconServiceTradeOfferConfirmationMethod ConfirmationMethod { get; set; }
    }
}