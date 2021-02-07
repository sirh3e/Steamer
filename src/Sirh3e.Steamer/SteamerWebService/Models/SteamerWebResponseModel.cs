using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.SteamerWebService.Models
{
    public class SteamerWebResponseModel<TResponseModel>
    {
        [JsonPropertyName("response")]
        public TResponseModel Response { get; set; }
    }
}