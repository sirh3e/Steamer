using System;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame
{
    public class SteamerWebAchievementModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("defaultvalue")]
        public ulong DefaultValue { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("hidden")]
        public long Hidden { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public Uri Icon { get; set; }

        [JsonPropertyName("icongray")]
        public Uri IconGray { get; set; }
    }
}