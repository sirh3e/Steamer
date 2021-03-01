using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.RecentlyPlayedGames
{
    public class SteamerWebRecentlyPlayedGamesModel
    {
        [JsonPropertyName("total_count")]
        public ulong TotalCount { get; set; }

        [JsonPropertyName("games")]
        public List<SteamerWebGameModel> Games { get; set; } = new();
    }
}