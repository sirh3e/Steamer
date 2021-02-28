using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.PlayerAchievements
{
    public class SteamerWebPlayerAchievementsModel
    {
        [JsonPropertyName("playerstats")]
        public SteamerWebPlayerStatsModel PlayerStats { get; set; }
    }
}