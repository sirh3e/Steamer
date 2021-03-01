using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.SteamLevel;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response
{
    public interface ISteamerWebSteamLevelResponse : ISteamerResponse<ISteamerWebSteamLevelRequest,
        SteamerWebResponseModel<SteamerWebSteamLevelModel>>
    {
    }
}