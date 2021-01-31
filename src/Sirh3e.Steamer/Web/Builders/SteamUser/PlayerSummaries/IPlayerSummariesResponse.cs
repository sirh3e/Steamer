using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries
{
    public interface IPlayerSummariesResponse : ISteamerResponse<ResponseModel<PlayerSummariesModel>>
    {
    }
}