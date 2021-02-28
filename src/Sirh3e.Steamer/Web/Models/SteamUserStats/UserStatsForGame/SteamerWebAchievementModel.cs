using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame
{
    public class SteamerWebAchievementModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("achieved")]
        public ulong Achieved { get; set; }
    }
}