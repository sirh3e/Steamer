using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser.Binders
{
    public interface
        ISteamerWebServicePlayerBansBinder : ISteamerServiceBinder<ISteamerWebPlayerBansRequest,
            ISteamerWebPlayerBansResponse>
    {
    }
}