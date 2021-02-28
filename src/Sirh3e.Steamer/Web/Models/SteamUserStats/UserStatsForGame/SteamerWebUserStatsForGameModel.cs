using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame
{
    public class SteamerWebUserStatsForGameModel
    {
        [JsonPropertyName("playerstats")]
        public SteamerWebPlayerStatsModel PlayerStats { get; set; }
    }
}