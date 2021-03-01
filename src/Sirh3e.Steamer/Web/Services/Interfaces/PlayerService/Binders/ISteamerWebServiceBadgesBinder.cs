using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Response;

namespace Sirh3e.Steamer.Web.Services.PlayerService.Binders
{
    public interface ISteamerWebServiceBadgesBinder
        : ISteamerServiceBinder<ISteamerWebBadgesRequest, ISteamerWebBadgesResponse>
    {
    }
}