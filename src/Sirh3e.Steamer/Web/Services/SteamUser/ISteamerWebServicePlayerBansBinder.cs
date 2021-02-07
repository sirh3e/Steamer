using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface ISteamerWebServicePlayerBansBinder : ISteamerServiceBinder<IPlayerBansRequest, IPlayerBansResponse>
    {
    }
}