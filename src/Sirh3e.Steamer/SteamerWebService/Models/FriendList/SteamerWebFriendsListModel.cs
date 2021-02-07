using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.SteamerWebService.Models.FriendList
{
    public class SteamerWebFriendsListModel
    {
        [JsonPropertyName("friendslist")]
        public SteamerWebFriendsModel SteamerWebFriendsList { get; set; }
    }
}