using System;
using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.PlayerSummaries
{
    public class PlayerModel
    {
        [JsonProperty("steamid")] public string SteamId { get; set; }

        [JsonProperty("communityvisibilitystate")]
        public long CommunityVisibilityState { get; set; }

        [JsonProperty("profilestate")] public long ProfileState { get; set; }

        [JsonProperty("personaname")] public string PersonaName { get; set; }

        [JsonProperty("lastlogoff")] public long LastLogoff { get; set; }

        [JsonProperty("commentpermission")] public long CommentPermission { get; set; }

        [JsonProperty("profileurl")] public Uri ProfileUrl { get; set; }

        [JsonProperty("avatar")] public Uri Avatar { get; set; }

        [JsonProperty("avatarmedium")] public Uri AvatarMedium { get; set; }

        [JsonProperty("avatarfull")] public Uri AvatarFull { get; set; }

        [JsonProperty("personastate")] public long Personastate { get; set; }

        [JsonProperty("primaryclanid")] public string PrimaryClanId { get; set; }

        [JsonProperty("timecreated")] public long TimeCreated { get; set; }

        [JsonProperty("personastateflags")] public long PersonaStateFlags { get; set; }

        [JsonProperty("loccountrycode")] public string LocCountryCode { get; set; }
    }
}