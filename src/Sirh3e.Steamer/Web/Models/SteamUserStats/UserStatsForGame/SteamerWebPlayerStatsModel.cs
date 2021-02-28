using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame
{
    public class SteamerWebPlayerStatsModel
    {
        [JsonPropertyName("steamID")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong SteamId { get; set; }

        [JsonPropertyName("gameName")]
        public string GameName { get; set; }

        [JsonPropertyName("stats")]
        public List<SteamerWebStatsModel> Stats { get; set; }

        [JsonPropertyName("achievements")]
        public List<SteamerWebAchievementModel> Achievements { get; set; } = new();
    }
}