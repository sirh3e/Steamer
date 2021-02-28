using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.GlobalAchievementPercentagesForApp
{
    public class SteamerWebGlobalAchievementPercentagesForAppModel
    {
        [JsonPropertyName("achievements")]
        public List<SteamerWebAchievementModel> Achievements { get; set; } = new();
    }
}