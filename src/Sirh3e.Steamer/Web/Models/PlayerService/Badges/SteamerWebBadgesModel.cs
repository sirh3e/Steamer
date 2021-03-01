using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.Badges
{
    public class SteamerWebBadgesModel
    {
        [JsonPropertyName("badges")]
        public List<SteamerWebBadgeModel> Badges { get; set; } = new();

        [JsonPropertyName("player_xp")]
        public ulong PlayerXp { get; set; }

        [JsonPropertyName("player_level")]
        public ulong PlayerLevel { get; set; }

        [JsonPropertyName("player_xp_needed_to_level_up")]
        public ulong PlayerXpNeededToLevelUp { get; set; }

        [JsonPropertyName("player_xp_needed_current_level")]
        public ulong PlayerXpNeededCurrentLevel { get; set; }
    }
}