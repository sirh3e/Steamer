using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.FriendList
{
    public class FriendsListModel
    {
        [JsonPropertyName("friendslist")]
        public FriendsModel FriendsList { get; set; }
    }
}