using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.PlayerService.CommunityBadgeProgress
{
    public class SteamerWebQuestModel
    {
        [JsonPropertyName("questid")]
        public ulong QuestId { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }
    }
}