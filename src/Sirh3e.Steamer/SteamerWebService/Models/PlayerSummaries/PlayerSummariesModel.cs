﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.SteamerWebService.Models.PlayerSummaries
{
    public class PlayerSummariesModel
    {
        [JsonPropertyName("players")]
        public List<PlayerModel> Players { get; set; } = new();
    }
}