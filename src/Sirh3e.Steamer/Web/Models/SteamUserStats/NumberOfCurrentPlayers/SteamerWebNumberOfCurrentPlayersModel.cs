using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUserStats.NumberOfCurrentPlayers
{
    public class SteamerWebNumberOfCurrentPlayersModel
    {
        [JsonPropertyName("player_count")]
        public ulong PlayerCount { get; set; }

        [JsonPropertyName("result")]
        public ulong Result { get; set; }
    }
}