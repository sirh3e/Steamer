using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Response;

namespace Sirh3e.Steamer.Web.Services.PlayerService.Binders
{
    public interface ISteamerWebServiceCommunityBadgeProgressBinder
        : ISteamerServiceBinder<ISteamerWebCommunityBadgeProgressRequest, ISteamerWebCommunityBadgeProgressResponse>
    {
    }
}