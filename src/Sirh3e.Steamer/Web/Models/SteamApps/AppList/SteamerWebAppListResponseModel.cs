using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamApps.AppList
{
    public class SteamerWebAppListResponseModel
    {
        [JsonPropertyName("applist")]
        public SteamerWebAppListModel AppList { get; set; }
    }
}