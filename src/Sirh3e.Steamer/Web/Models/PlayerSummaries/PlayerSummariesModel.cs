using System.Collections.Generic;

using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.PlayerSummaries {
    public class PlayerSummariesModel {
        [JsonProperty("players")] public List<PlayerModel> Players { get; set; } = new();
    }
}