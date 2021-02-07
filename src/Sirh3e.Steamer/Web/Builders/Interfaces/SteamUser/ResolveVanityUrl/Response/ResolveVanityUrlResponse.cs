using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.ResolveVanityUrl;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public class ResolveVanityUrlResponse : IResolveVanityUrlResponse
    {
        public IResolveVanityUrlRequest Request { get; init; }
        public Option<ResponseModel<ResolveVanityUrlModel>> Model { get; init; }
    }
}