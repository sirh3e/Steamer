using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamApps.AppList
{
    public class SteamerWebAppListModel
    {
        [JsonPropertyName("apps")]
        public List<SteamerWebAppModel> Apps { get; set; } = new();
    }
}