using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.FriendList
{
    public class SteamerWebFriendsListModel
    {
        [JsonPropertyName("friendslist")]
        public SteamerWebFriendsModel FriendsList { get; set; }
    }
}