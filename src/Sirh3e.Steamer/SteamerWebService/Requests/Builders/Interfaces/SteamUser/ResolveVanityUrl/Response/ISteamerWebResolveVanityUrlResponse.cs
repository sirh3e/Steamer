using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.ResolveVanityUrl;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public interface ISteamerWebResolveVanityUrlResponse : ISteamerResponse<ISteamerWebResolveVanityUrlRequest,
        SteamerWebResponseModel<SteamerWebResolveVanityUrlModel>>
    {
    }
}