using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sirh3e.Rust.Panic;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.Rust;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var key = "1A3E61134C39581437B9CFEADD8C87AD";
            var (service, client) = SteamerWebFactory.CreateByKey(key);

            var stopwatch = Stopwatch.StartNew();

            async Task<ulong> OnErr(ISteamerWebError error)
            {
                return (await error.HttpResponseMessage.Match(message =>
                    {
                        return (int)message.StatusCode switch
                        {
                            >= 400 and < 500 => client
                                .SteamUser
                                .ResolveVanityUrl
                                .Build(error.Request.Method.Parameters)
                                .ExecuteAsync(service),
                            _ => throw new NotImplementedException()
                        };
                    }, () => throw new NotImplementedException()))
                    .Map(response => response.Model)
                    .Map(
                        model =>
                        model
                            .Map(response => response.Response.SteamId)
                            .UnwrapOr(0)
                        )
                    .UnwrapOr(0);
            }

            var result = await client
                .SteamUser
                .ResolveVanityUrl
                .SetVanityUrl("xtrivax")
                .Build()
                .ExecuteAsync(service);

            var steamId = result
                .MapOrElse(error => throw new PanicException(error.Message), response => response.Model.MapOr(0UL, model => model.Response.SteamId));

            var task = await client
                .SteamUser
                .FriendList
                .SetSteamId(steamId)
                .Build()
                .ExecuteAsync(service);

            var steamIds = task.Map(
                    response =>
                    response.Model
                        .Map(model => model.FriendsList.Friends.Select(friend => friend.SteamId))
                        .UnwrapOrDefault())
                .UnwrapOrDefault();

            stopwatch.Stop();

            Console.WriteLine(string.Join(", ", steamIds));
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}