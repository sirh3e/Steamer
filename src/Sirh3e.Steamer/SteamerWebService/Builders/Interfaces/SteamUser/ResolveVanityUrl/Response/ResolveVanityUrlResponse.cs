using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.ResolveVanityUrl;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public class ResolveVanityUrlResponse : IResolveVanityUrlResponse
    {
        public IResolveVanityUrlRequest Request { get; init; }
        public Option<ResponseModel<ResolveVanityUrlModel>> Model { get; init; }
    }
}