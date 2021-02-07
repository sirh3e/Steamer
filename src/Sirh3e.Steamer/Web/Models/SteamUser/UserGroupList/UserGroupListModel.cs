using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList
{
    public class UserGroupListModel
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("groups")]
        public List<GroupModel> Groups { get; set; }
    }
}