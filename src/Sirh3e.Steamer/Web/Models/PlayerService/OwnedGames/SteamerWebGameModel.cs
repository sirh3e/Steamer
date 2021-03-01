using System;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.OwnedGames
{
    public class SteamerWebGameModel
    {
        [JsonPropertyName("appid")]
        public ulong AppId { get; set; }

        [JsonPropertyName("playtime_forever")]
        public ulong PlaytimeForever { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("img_icon_url")]
        public Uri ImgIconUrl { get; set; }

        [JsonPropertyName("img_logo_url")]
        public Uri ImgLogoUrl { get; set; }

        [JsonPropertyName("has_community_visible_stats")]
        public bool? HasCommunityVisibleStats { get; set; }

        [JsonPropertyName("playtime_2weeks")]
        public ulong? Playtime2Weeks { get; set; }
    }
}