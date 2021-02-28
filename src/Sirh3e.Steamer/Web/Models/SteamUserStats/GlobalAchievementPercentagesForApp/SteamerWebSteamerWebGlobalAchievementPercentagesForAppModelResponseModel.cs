using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.GlobalAchievementPercentagesForApp
{
    public class SteamerWebSteamerWebGlobalAchievementPercentagesForAppModelResponseModel
    {
        [JsonPropertyName("achievementpercentages")]
        public SteamerWebGlobalAchievementPercentagesForAppModel AchievementPercentages { get; set; }
    }
}