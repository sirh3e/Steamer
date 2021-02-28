using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame
{
    public class SteamerWebSchemaForGameModel
    {
        [JsonPropertyName("game")]
        public SteamerWebGameModel Game { get; set; }
    }
}