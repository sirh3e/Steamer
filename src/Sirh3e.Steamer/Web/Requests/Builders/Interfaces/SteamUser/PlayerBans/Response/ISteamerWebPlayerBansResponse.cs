using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response
{
    public interface
        ISteamerWebPlayerBansResponse : ISteamerResponse<ISteamerWebPlayerBansRequest, SteamerWebPlayerBansModel>
    {
    }
}