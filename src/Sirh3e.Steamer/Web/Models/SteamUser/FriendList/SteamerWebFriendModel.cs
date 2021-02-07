using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.FriendList
{
    public class SteamerWebFriendModel
    {
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }

        [JsonPropertyName("relationship")]
        public string Relationship { get; set; }

        [JsonPropertyName("friend_since")]
        public long FriendSince { get; set; }
    }
}