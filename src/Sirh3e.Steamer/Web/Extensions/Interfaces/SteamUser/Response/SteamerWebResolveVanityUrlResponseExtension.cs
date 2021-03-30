using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Response
{
    public static class SteamerWebResolveVanityUrlResponseExtension
    {
        //ToDo find a better name for it
        public static Task<Result<ISteamerWebResolveVanityUrlResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebResolveVanityUrlResponse response,
            ISteamerWebService service)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return response.Request.ExecuteAsync(service);
        }
    }
}