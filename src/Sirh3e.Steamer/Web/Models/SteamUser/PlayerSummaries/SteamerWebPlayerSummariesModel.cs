using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.PlayerSummaries
{
    public class SteamerWebPlayerSummariesModel
    {
        [JsonPropertyName("players")]
        public List<SteamerWebPlayerModel> Players { get; set; } = new();
    }
}