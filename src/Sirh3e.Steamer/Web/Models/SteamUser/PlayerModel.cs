using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser
{
    public class PlayerModel
    {
        [JsonPropertyName("SteamId")]
        public string SteamId { get; set; }

        [JsonPropertyName("CommunityBanned")]
        public bool CommunityBanned { get; set; }

        [JsonPropertyName("VACBanned")]
        public bool VacBanned { get; set; }

        [JsonPropertyName("NumberOfVACBans")]
        public long NumberOfVacBans { get; set; }

        [JsonPropertyName("DaysSinceLastBan")]
        public long DaysSinceLastBan { get; set; }

        [JsonPropertyName("NumberOfGameBans")]
        public long NumberOfGameBans { get; set; }

        [JsonPropertyName("EconomyBan")]
        public string EconomyBan { get; set; }
    }
}