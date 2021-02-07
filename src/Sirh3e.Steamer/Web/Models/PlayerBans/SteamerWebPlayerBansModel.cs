using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerBans
{
    public class SteamerWebPlayerBansModel
    {
        [JsonPropertyName("players")]
        public List<SteamerWebPlayerModel> Players { get; set; } = new();
    }
}