using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Response;

namespace Sirh3e.Steamer.Web.Services.PlayerService.Binders
{
    public interface ISteamerWebServiceSteamLevelBinder
        : ISteamerServiceBinder<ISteamerWebSteamLevelRequest, ISteamerWebSteamLevelResponse>
    {
    }
}