using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame
{
    public class SteamerWebStatsModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public ulong Value { get; set; }
    }
}