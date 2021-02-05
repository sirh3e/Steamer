using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models
{
    public class ResponseModel<TResponseModel>
    {
        [JsonPropertyName("response")]
        public TResponseModel Response { get; set; }
    }
}