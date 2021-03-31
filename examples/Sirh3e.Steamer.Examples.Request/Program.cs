using System;
using System.Threading.Tasks;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.Rust;

namespace Sirh3e.Steamer.Examples.Request
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Create a api key: https://steamcommunity.com/dev/apikey keep is secure
            var key = "YOUR API KEY";

            //Have a look at Sirh3e.Steamer.Examples.Setup
            var (service, client) = SteamerWebFactory.CreateByKey(key);

            //DISCLAIMER:
            //  This repository uses a library (Sirh3e.Rust) to mimic rust like error handling in C#.
            //  In this first example, it is then used in a more C# if else style way.
            //  In the latter example, it is written with a lambda functions with is the preferred way of using this library.
            //  If you have questions look at the rust documentation or open an issue https://github.com/sirh3e/Steamer/issues/new/choose.
            //  Informatics about rust:
            //      Have a look at: https://doc.rust-lang.org/rust-by-example/error/result.html
            //      Have a look at: https://doc.rust-lang.org/std/result/enum.Result.html
            //      Have a look at: https://doc.rust-lang.org/rust-by-example/error/option_unwrap.html?highlight=option#op
            //      Have a look at: https://doc.rust-lang.org/std/option/enum.Option.html

            //Simple
            {
                var request = client.SteamUser.ResolveVanityUrl.SetVanityUrl("h3e").Build();
                var task = service.ExecuteAsync(request);
                var result = await task;

                if ( result.IsOk )
                {
                    //Request passed

                    var response = result.Unwrap();
                    var option = response.Model;

                    if ( option.IsSome )
                    {
                        var model = option.Unwrap();
                        var steamId = model.Response.SteamId;

                        Console.WriteLine(steamId);
                    }
                    else
                    {
                        //Something went wrong on creating the model
                    }
                }
                else
                {
                    var error = result.UnwrapErr();

                    //Do some other magic maybe resolve the error :D
                    Console.WriteLine(error.Message);
                }

                //Do some magic here
            }

            //Fluent
            {
                //OnErr where the throw new NotImplementedException is handle the error your self :D

                var steamId = (await client.SteamUser.ResolveVanityUrl
                    .SetVanityUrl("h3e")
                    .Build()
                    .ExecuteAsync(service))
                    .Match(response => response.Model.Map(model => model.Response.SteamId).UnwrapOrDefault(),
                                error => throw new NotImplementedException());

                Console.WriteLine(steamId);
            }

            //Another example
            {
                //OnErr where the throw new NotImplementedException is handle the error your self :D

                const ulong steamId = 76561198220146080UL;
                var friends = (await client.SteamUser.FriendList
                            .SetSteamId(steamId)
                            .Build()
                            .ExecuteAsync(service))
                            .Match(response => response.Model.Map(model => model.FriendsList.Friends).UnwrapOrDefault(), err => throw new NotImplementedException());

                friends.ForEach(friend => Console.WriteLine($"[{new DateTime(1970, 1, 1).AddSeconds(friend.FriendSince):yyyy MMMM dd}]: {friend.SteamId}"));
            }

            //Total async
            {
                //OnErr where the throw new NotImplementedException is handle the error your self :D

                const ulong steamId = 76561198220146080UL;
                var task = client.SteamUser.FriendList
                        .SetSteamId(steamId)
                        .Build()
                        .ExecuteAsync(service)
                        .MatchAsync(response => response.Model.Map(model => model.FriendsList.Friends).UnwrapOrDefault(), err => throw new NotImplementedException());

                //do what ever you want 
            }
        }
    }
}