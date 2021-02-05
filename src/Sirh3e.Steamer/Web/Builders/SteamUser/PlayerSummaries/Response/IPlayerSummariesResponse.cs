using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Response
{
    public interface
        IPlayerSummariesResponse : ISteamerResponse<IPlayerSummariesRequest, ResponseModel<PlayerSummariesModel>>
    {
    }
}