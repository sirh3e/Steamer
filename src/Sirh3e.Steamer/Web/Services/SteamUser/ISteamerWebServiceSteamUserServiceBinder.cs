using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface ISteamerWebServiceSteamUserServiceBinder :
        ISteamerServiceBinder<IPlayerBansRequest, IPlayerBansResponse>,
        ISteamerServiceBinder<IPlayerSummariesRequest, IPlayerSummariesResponse>
    {
    }
}