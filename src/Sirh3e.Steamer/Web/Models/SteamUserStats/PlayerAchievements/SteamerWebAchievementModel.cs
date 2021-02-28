using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.PlayerAchievements
{
    public class SteamerWebAchievementModel
    {
        [JsonPropertyName("apiname")]
        public string ApiName { get; set; }

        [JsonPropertyName("achieved")]
        public long Achieved { get; set; }

        [JsonPropertyName("unlocktime")]
        public ulong UnlockTime { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}