using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList
{
    public class GroupModel
    {
        [JsonPropertyName("gid")]
        public string Gid { get; set; }
    }
}