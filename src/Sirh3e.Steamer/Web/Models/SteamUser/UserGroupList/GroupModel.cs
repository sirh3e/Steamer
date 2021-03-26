using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList
{
    public class SteamerGroupModel
    {
        [JsonPropertyName("gid")]
        public string Gid { get; set; }
    }
}