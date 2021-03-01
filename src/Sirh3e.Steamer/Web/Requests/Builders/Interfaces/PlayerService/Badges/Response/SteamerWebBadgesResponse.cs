using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.PlayerService.Badges;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Response
{
    public class SteamerWebBadgesResponse : ISteamerWebBadgesResponse
    {
        public ISteamerWebBadgesRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebBadgesModel>> Model { get; init; }
    }
}