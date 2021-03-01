using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.Badges;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Response
{
    public interface ISteamerWebBadgesResponse : ISteamerResponse<ISteamerWebBadgesRequest,
        SteamerWebResponseModel<SteamerWebBadgesModel>>
    {
    }
}