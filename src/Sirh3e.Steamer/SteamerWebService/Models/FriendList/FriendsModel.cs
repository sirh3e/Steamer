using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.SteamerWebService.Models.FriendList
{
    public class FriendsModel
    {
        [JsonPropertyName("friends")]
        public List<FriendModel> Friends { get; set; } = new();
    }
}