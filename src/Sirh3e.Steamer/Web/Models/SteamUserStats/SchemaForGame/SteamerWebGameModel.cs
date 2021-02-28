using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame
{
    public class SteamerWebGameModel
    {
        [JsonPropertyName("gameName")]
        public string GameName { get; set; }

        [JsonPropertyName("gameVersion")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong GameVersion { get; set; }

        [JsonPropertyName("availableGameStats")]
        public SteamerWebAvailableGameStatsModel AvailableGameStats { get; set; }
    }
}