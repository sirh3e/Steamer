using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame
{
    public class SteamerWebAvailableGameStatsModel
    {
        [JsonPropertyName("stats")]
        public List<SteamerWebStatsModel> Stats { get; set; }

        [JsonPropertyName("achievements")]
        public List<SteamerWebAchievementModel> Achievements { get; set; }
    }
}