using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.ResolveVanityUrl
{
    public class ResolveVanityUrlModel
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }

        [JsonPropertyName("success")]
        public long Success { get; set; } //ToDo maybe change it to boolean makes more sense 
    }
}