using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.Rust;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var apiKey = "1A3E61134C39581437B9CFEADD8C87AD";
            var (service, client) = SteamerWebFactory.CreateByKey(apiKey);

            var stopwatch = Stopwatch.StartNew();

            var steamId = await client
                .SteamUser
                .ResolveVanityUrl
                .SetVanityUrl("xtrivax")
                .Build()
                .ExecuteAsync(service)
                .MatchAsync(response => response.Model.Match(model => model.SteamId, () => throw new NotImplementedException()), error => throw new NotImplementedException());

            var steamIds = await client
                .SteamUser
                .FriendList
                .SetSteamId(steamId)
                .Build()
                .ExecuteAsync(service)
                .MatchAsync(response => response.Model.Match(model => 
                    model.FriendsList.Friends
                    .OrderBy(friend => friend.FriendSince)
                    .Select(friend => friend.SteamId)
                    , () => throw new NotImplementedException()), err => throw new NotImplementedException());

            stopwatch.Stop();
            
            Console.WriteLine(string.Join(", ", steamIds));
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}