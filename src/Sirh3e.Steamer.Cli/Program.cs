using System;
using System.Net.Http;
using System.Text.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http;
using Sirh3e.Steamer.Core.Serializer.Providers;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Response;
using Sirh3e.Steamer.Web.Serializers.Json;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiKey = "4651E4B7A003AF0324058260A869F432";
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
            var response = client.SteamerUser.FriendList
                .SetKey(apiKey)
                .SetSteamId(76561198220146080)
                .Build()
                .ServiceExecute(service)
                .RetryServiceExecute(service);
            //.RetryServiceExecute(service);

            var end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds}s");

            var option = response.Model;
            option.Match(model =>
                         {
                             model.FriendsList.Friends.ForEach(f => { }
                                                              //Console
                                                              //    .WriteLine($"steamid: {f.SteamId} url: {f.FriendSince}")
                                                              );
                         },
                         () => { Console.WriteLine("some error"); });
        }
    }
}