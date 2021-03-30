using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUserStats.Request
{
    public static class SteamerWebSchemaForGameRequestExtension
    {
        public static Task<Result<ISteamerWebSchemaForGameResponse, ISteamerWebError>> ExecuteAsync(
            this ISteamerWebSchemaForGameRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.ExecuteAsync(request);
        }
    }
}