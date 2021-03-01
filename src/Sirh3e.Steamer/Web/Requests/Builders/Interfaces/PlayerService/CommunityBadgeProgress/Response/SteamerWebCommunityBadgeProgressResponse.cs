using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.CommunityBadgeProgress;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Response
{
    public class SteamerWebCommunityBadgeProgressResponse : ISteamerWebCommunityBadgeProgressResponse
    {
        public ISteamerWebCommunityBadgeProgressRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebCommunityBadgeProgressModel>> Model { get; init; }
    }
}