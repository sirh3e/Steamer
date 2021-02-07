using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Response;

namespace Sirh3e.Steamer.SteamerWebService.Services.SteamUser
{
    public interface
        ISteamerWebServicePlayerSummariesBinder : ISteamerServiceBinder<IPlayerSummariesRequest,
            IPlayerSummariesResponse>
    {
    }
}