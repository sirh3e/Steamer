using System;
using System.Net.Http;
using Newtonsoft.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http;
using Sirh3e.Steamer.Core.Serializer.Providers;
using Sirh3e.Steamer.Web.Serializers.Json;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var starTime = DateTime.Now;

            var apiKey = "4651E4B7A003AF0324058260A869F432";
            var client = new SteamerWebClient.Builder()
                .SetAuthProvider(new SteamerAuthProvider(apiKey))
                .SetSerializerProvider(new SteamerSerializerProvider.Builder()
                    .SetSerializer(new NewtonsoftSerializer(JsonConvert.DeserializeObject))
                    .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());
            var service = new SteamerWebService(client, httpClientProvider);


            var request = client.SteamerUser.PlayerSummaries
                .SetKey(apiKey)
                .SetSteamIds(76561198220146080)
                .Build();
            //.ServieExecute(service);

            var response = service.Execute(request);
            
            var option = response.Model;

            option.Match(
                model =>
                {
                    model.Response.Players.ForEach(p =>
                        Console.WriteLine($"steamid: {p.SteamId} url: {p.PrimaryClanId}"));
                },
                () => { Console.WriteLine("some error"); });

            var endTime = DateTime.Now;

            Console.WriteLine($"{(endTime - starTime).TotalSeconds}s");
        }
    }
}