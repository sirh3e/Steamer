using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.OwnedGames
{
    public class SteamerWebOwnedGamesModel
    {
        public int GameCount => Games.Count;

        [JsonPropertyName("games")]
        public List<SteamerWebGameModel> Games { get; set; } = new();
    }
}