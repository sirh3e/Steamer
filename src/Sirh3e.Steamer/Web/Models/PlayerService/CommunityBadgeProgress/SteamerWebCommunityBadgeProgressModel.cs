using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.CommunityBadgeProgress
{
    public class SteamerWebCommunityBadgeProgressModel
    {
        [JsonPropertyName("quests")]
        public List<SteamerWebQuestModel>? Quests { get; set; }
    }
}