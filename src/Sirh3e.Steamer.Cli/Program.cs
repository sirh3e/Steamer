using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Serializers.Json;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web.Extensions.EconService.Request;
using Sirh3e.Steamer.Web.Extensions.Rust;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiKey = "4BBB0ECB41D910368C4586A498598524";
            var client = new SteamerWebClient.Builder()
                .SetAuthProvider(new SteamerAuthProvider(apiKey))
                .SetSerializerProvider(new SteamerSerializerProvider.Builder()
                                           .SetSerializer(new SteamerSystemTextJsonSerializer(new
                                                                                                  SteamerSystemTextJsonSerializerOptionsProvider(new
                                                                                                      JsonSerializerOptions
                                                                                                  {
                                                                                                      DefaultIgnoreCondition =
                                                                                                              JsonIgnoreCondition
                                                                                                                  .WhenWritingNull
                                                                                                  })))
                                           .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());
            var service = new SteamerWebService(client, httpClientProvider);

            //https://steamcommunity.com/profiles/76561198835334341/

            var response = client.SteamUser.FriendList.SetKey(apiKey).SetSteamId(76561198835334341).Build()
                .ServiceExecute(service);

            response.Model.Match(mode => { mode.FriendsList.Friends.ForEach(f => Console.WriteLine($"{f.SteamId}")); },
                                 () => { });

            client.EconService.TradeHistory.SetKey(apiKey).SetMaxTrades(5).Build()
                .ServiceExecute(service)
                .Model.Match(model =>
                {
                    model.Trades.ForEach(t => Console.WriteLine($"{t.TradeId}"));

                    Console.WriteLine($"{model.Trades.Count}");
                }, () => { });

            /*
                        var start = DateTime.Now;
                        var response = client.SteamUser.ResolveVanityUrl
                            .SetKey(apiKey)
                            .SetVanityUrl("xtrivax")
                            .Build()
                            .ServiceExecute(service)
                            .RetryServiceExecute(service);

                        var end = DateTime.Now;

                        Console.WriteLine($"{(end - start).TotalSeconds}");

                        response.Model.Match(some =>
                        {

                        }, () =>
                        {

                        });

                        response.Model.Match(some => 
                            {
                                Console.WriteLine($"{nameof(some.Response.SteamId)}: '{some.Response.SteamId}'");
                            },
                            () =>
                            {

                            });
                            */
        }
    }
}