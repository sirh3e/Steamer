using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface
        ISteamerWebServicePlayerSummariesBinder : ISteamerServiceBinder<IPlayerSummariesRequest,
            IPlayerSummariesResponse>
    {
    }
}