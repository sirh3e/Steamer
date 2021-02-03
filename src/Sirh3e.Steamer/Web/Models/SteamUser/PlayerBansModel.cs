using System.Collections.Generic;

using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.SteamUser {
    public class PlayerBansModel {
        [JsonProperty("players")] public List<PlayerModel> Players { get; set; } = new();
    }
}