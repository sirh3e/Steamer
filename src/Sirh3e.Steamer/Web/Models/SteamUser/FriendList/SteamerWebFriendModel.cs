using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.SteamUser.FriendList
{
    public class SteamerWebFriendModel
    {
        [JsonPropertyName("steamid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong SteamId { get; set; }

        [JsonPropertyName("relationship")]
        public string Relationship { get; set; }

        [JsonPropertyName("friend_since")]
        public ulong FriendSince { get; set; }
    }
}