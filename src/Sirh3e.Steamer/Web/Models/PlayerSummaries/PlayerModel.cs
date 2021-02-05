using System;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerSummaries
{
    public class PlayerModel
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }

        [JsonPropertyName("communityvisibilitystate")]
        public long CommunityVisibilityState { get; set; }

        [JsonPropertyName("profilestate")]
        public long ProfileState { get; set; }

        [JsonPropertyName("personaname")]
        public string PersonaName { get; set; }

        [JsonPropertyName("lastlogoff")]
        public long LastLogoff { get; set; }

        [JsonPropertyName("commentpermission")]
        public long CommentPermission { get; set; }

        [JsonPropertyName("profileurl")]
        public Uri ProfileUrl { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarmedium")]
        public Uri AvatarMedium { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri AvatarFull { get; set; }

        [JsonPropertyName("personastate")]
        public long Personastate { get; set; }

        [JsonPropertyName("primaryclanid")]
        public string PrimaryClanId { get; set; }

        [JsonPropertyName("timecreated")]
        public long TimeCreated { get; set; }

        [JsonPropertyName("personastateflags")]
        public long PersonaStateFlags { get; set; }

        [JsonPropertyName("loccountrycode")]
        public string LocCountryCode { get; set; }
    }
}