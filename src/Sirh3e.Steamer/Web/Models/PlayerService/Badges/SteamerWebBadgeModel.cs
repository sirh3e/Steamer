using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.PlayerService.Badges
{
    public class SteamerWebBadgeModel
    {
        [JsonPropertyName("badgeid")]
        public int BadgeId { get; set; }

        [JsonPropertyName("level")]
        public ulong Level { get; set; }

        [JsonPropertyName("completion_time")]
        public ulong CompletionTime { get; set; }

        [JsonPropertyName("xp")]
        public ulong Xp { get; set; }

        [JsonPropertyName("scarcity")]
        public ulong Scarcity { get; set; }

        [JsonPropertyName("appid")]
        public uint? Appid { get; set; }

        [JsonPropertyName("communityitemid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong? CommunityItemId { get; set; }

        [JsonPropertyName("border_color")]
        public ulong? BorderColor { get; set; }
    }
}