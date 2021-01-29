using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.SteamUser
{
    public class PlayerModel
    {
        [JsonProperty("SteamId")] public string SteamId { get; set; }

        [JsonProperty("CommunityBanned")] public bool CommunityBanned { get; set; }

        [JsonProperty("VACBanned")] public bool VacBanned { get; set; }

        [JsonProperty("NumberOfVACBans")] public long NumberOfVacBans { get; set; }

        [JsonProperty("DaysSinceLastBan")] public long DaysSinceLastBan { get; set; }

        [JsonProperty("NumberOfGameBans")] public long NumberOfGameBans { get; set; }

        [JsonProperty("EconomyBan")] public string EconomyBan { get; set; }
    }
}