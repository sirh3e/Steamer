using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Models.PlayerBans;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Response
{
    public interface IPlayerBansResponse : ISteamerResponse<IPlayerBansRequest, PlayerBansModel>
    {
    }
}