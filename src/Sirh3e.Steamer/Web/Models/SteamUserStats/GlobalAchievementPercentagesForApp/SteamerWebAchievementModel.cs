using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.GlobalAchievementPercentagesForApp
{
    public class SteamerWebAchievementModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("percent")]
        public double Percent { get; set; }
    }
}