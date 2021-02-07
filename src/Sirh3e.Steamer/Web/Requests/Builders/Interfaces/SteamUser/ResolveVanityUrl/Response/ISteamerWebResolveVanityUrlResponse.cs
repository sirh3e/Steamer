using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.SteamUser.ResolveVanityUrl;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public interface ISteamerWebResolveVanityUrlResponse : ISteamerResponse<ISteamerWebResolveVanityUrlRequest,
        SteamerWebResponseModel<SteamerWebResolveVanityUrlModel>>
    {
    }
}