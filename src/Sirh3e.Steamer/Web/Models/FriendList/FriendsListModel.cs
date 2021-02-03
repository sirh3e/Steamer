using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.FriendList {
    public class FriendsListModel {
        [JsonProperty("friendslist")] public FriendsModel FriendsList { get; set; }
    }
}