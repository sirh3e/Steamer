using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.FriendList
{
    public class FriendModel
    {
        public class Friend
        {
            [JsonPropertyName("steamid")]
            public string SteamId { get; set; }

            [JsonPropertyName("relationship")]
            public string Relationship { get; set; }

            [JsonPropertyName("friend_since")]
            public long FriendSince { get; set; }
        }
    }
}