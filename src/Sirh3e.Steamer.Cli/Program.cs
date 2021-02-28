using System;
using System.Net.Http;
using System.Text.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Serializers.Json;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web.Extensions.Interfaces.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.Rust;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiKey = "D307045B67D6513FFACE19257331AF5A";
            var client = new SteamerWebClient.Builder()
                .SetAuthProvider(new SteamerAuthProvider(apiKey))
                .SetSerializerProvider(new SteamerSerializerProvider.Builder()
                                           .SetSerializer(new SteamerSystemTextJsonSerializer(new
                                                                                                  SteamerSystemTextJsonSerializerOptionsProvider(new
                                                                                                      JsonSerializerOptions())))
                                           .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());
            var service = new SteamerWebService(client, httpClientProvider);
            
            var start = DateTime.Now;
            var response = client.SteamUser.ResolveVanityUrl.SetKey(apiKey).SetVanityUrl("xtrivax").Build().ServiceExecute(service);

            response.Model.Match(model =>
            {
                client.SteamUser.FriendList
                    .SetKey(apiKey)
                    .SetSteamId(model.SteamId)
                    .Build()
                    .ServiceExecute(service)
                    .Model
                    .Match(model =>
                {
                    //model.FriendsList.Friends.ForEach(f => Console.WriteLine(f.SteamId));
                    //Console.WriteLine(model.FriendsList.Friends.Count);
                }, () => { });
            }, () =>
            {

            });

            var end = DateTime.Now;

            Console.WriteLine($"{(end - start).TotalSeconds}s");
        }
    }
}