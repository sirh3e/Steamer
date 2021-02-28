using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame
{
    public class SteamerWebStatsModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("defaultvalue")]
        public ulong DefaultValue { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    }
}