using Sirh3e.Rust.Option;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.ResolveVanityUrl;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public class SteamerWebResolveVanityUrlResponse : ISteamerWebResolveVanityUrlResponse
    {
        public ISteamerWebResolveVanityUrlRequest Request { get; init; }
        public Option<SteamerWebResponseModel<SteamerWebResolveVanityUrlModel>> Model { get; init; }
    }
}