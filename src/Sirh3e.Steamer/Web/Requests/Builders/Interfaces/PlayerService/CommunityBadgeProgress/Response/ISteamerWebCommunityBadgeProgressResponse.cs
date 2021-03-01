using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.CommunityBadgeProgress;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Response
{
    public interface ISteamerWebCommunityBadgeProgressResponse : ISteamerResponse<ISteamerWebCommunityBadgeProgressRequest,
        SteamerWebResponseModel<SteamerWebCommunityBadgeProgressModel>>
    {
    }
}