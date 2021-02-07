using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Models.SteamUser;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Response
{
    public interface IPlayerBansResponse : ISteamerResponse<IPlayerBansRequest, PlayerBansModel>
    {
    }
}