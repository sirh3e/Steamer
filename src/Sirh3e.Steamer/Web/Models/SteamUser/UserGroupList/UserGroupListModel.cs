using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList
{
    public class SteamerUserGroupListModel
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("groups")]
        public List<SteamerGroupModel> Groups { get; set; }
    }
}