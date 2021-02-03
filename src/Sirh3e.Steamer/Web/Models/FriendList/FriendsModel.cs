using System.Collections.Generic;

using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models.FriendList {
    public class FriendsModel {
        [JsonProperty("friends")] public List<FriendModel.Friend> Friends { get; set; } = new();
    }
}