using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.PlayerSummaries;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Response
{
    public interface
        ISteamerWebPlayerSummariesResponse : ISteamerResponse<ISteamerWebPlayerSummariesRequest,
            SteamerWebResponseModel<SteamerWebPlayerSummariesModel>>
    {
    }
}