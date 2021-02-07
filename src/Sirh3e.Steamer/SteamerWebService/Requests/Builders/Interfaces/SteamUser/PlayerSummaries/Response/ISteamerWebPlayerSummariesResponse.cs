using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.PlayerSummaries;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response
{
    public interface
        ISteamerWebPlayerSummariesResponse : ISteamerResponse<ISteamerWebPlayerSummariesRequest,
            SteamerWebResponseModel<SteamerWebPlayerSummariesModel>>
    {
    }
}