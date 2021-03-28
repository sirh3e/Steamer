using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.Rust;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var apiKey = "";
            var (service, client) = SteamerWebFactory.CreateByApiKey(apiKey);

            var start = DateTime.Now;

            var resolveVanityUrlResponse = client
                .SteamUser
                .ResolveVanityUrl
                .SetVanityUrl("sirh3e")
                .Build()
                .Execute(service);

            var steamId = resolveVanityUrlResponse
                .Model
                .Match(
                    model => Option<ulong>.Some(model.Response.SteamId),
                    () => Option<ulong>.None
                    );

            var request = client
                .PlayerService
                .SteamLevel
                .SetSteamId(steamId.UnwrapOrElse(() => throw new NotImplementedException()))
                .Build();

            var response = service.Execute(request);

            response.Match(model =>
            {
                var level = model.PlayerLevel;
                Console.WriteLine(level);
            }, () => { });

            var end = DateTime.Now;

            Console.WriteLine($"{(end - start).TotalSeconds}s");
        }
    }
}