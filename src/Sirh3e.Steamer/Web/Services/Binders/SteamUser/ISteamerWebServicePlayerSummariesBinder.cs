using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;

namespace Sirh3e.Steamer.Web.Services.Binders.SteamUser
{
    public interface
        ISteamerWebServicePlayerSummariesBinder : ISteamerServiceBinder<ISteamerWebPlayerSummariesRequest,
            ISteamerWebPlayerSummariesResponse>
    {
    }
}