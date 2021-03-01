using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.OwnedGames
{
    public class SteamerWebOwnedGamesModel
    {
        [JsonPropertyName("game_count")]
        public ulong GameCount { get; set; }

        [JsonPropertyName("games")]
        public List<SteamerWebGameModel> Games { get; set; } = new();
    }
}