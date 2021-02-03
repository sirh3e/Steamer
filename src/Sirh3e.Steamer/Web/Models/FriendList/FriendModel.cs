using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.FriendList {
    public class FriendModel {
        public class Friend {
            [JsonProperty("steamid")] public string SteamId { get; set; }

            [JsonProperty("relationship")] public string Relationship { get; set; }

            [JsonProperty("friend_since")] public long FriendSince { get; set; }
        }
    }
}