using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerBans
{
    public class PlayerBansModel
    {
        [JsonPropertyName("players")]
        public List<PlayerModel> Players { get; set; } = new();
    }
}