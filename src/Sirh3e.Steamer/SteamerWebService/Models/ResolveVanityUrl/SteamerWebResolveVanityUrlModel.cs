using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.SteamerWebService.Models.ResolveVanityUrl
{
    public class SteamerWebResolveVanityUrlModel
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }

        [JsonPropertyName("success")]
        public long Success { get; set; } //ToDo maybe change it to boolean makes more sense 
    }
}