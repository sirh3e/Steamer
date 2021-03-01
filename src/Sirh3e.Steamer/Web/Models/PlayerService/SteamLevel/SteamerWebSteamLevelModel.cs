using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.SteamLevel
{
    public class SteamerWebSteamLevelModel
    {
        [JsonPropertyName("player_level")]
        public ulong PlayerLevel { get; set; }
    }
}