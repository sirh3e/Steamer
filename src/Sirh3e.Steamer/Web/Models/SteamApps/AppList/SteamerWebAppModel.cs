using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamApps.AppList
{
    public class SteamerWebAppModel
    {
        [JsonPropertyName("appid")]
        public uint AppId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}