using Newtonsoft.Json;

namespace Sirh3e.Steamer.Web.Models
{
    public class ResponseModel<TResponseModel>
    {
        [JsonProperty("response")] public TResponseModel Response { get; set; }
    }
}