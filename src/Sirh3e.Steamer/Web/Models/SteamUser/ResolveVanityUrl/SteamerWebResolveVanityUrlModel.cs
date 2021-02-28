using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Serializers.Json.Converters;

namespace Sirh3e.Steamer.Web.Models.SteamUser.ResolveVanityUrl
{
    public class SteamerWebResolveVanityUrlModel
    {
        [JsonPropertyName("steamid")]
        [JsonConverter(typeof(SteamerSystemTextJsonConverterStringToUlong))]
        public ulong SteamId { get; set; }

        [JsonPropertyName("success")]
        public long Success { get; set; } //ToDo maybe change it to boolean makes more sense 
    }
}