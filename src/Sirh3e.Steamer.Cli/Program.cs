using System;
using System.Net.Http;
using Newtonsoft.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Net.Http;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Utilities.Serializer.Json;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new SteamerWebClient.Builder()
                .SetAuthProvider(new SteamerAuthProvider(""))
                .SetSerializerProvider(new SteamerSerializerProvider.Builder()
                    .SetSerializer(new NewtonsoftSerializer(JsonConvert.DeserializeObject))
                    .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());

            var service = new SteamerWebService(client, httpClientProvider);

            var request = client.SteamUser.PlayerBans
                .SetKey("") //ToDo add your key here
                .SetSteamIds(76561198220146080)
                .Build();
            //.ServiceCall(service);

            var response = service.Call(request);
            var option = response.Model;

            option.Match(model => { model.Players.ForEach(p => Console.WriteLine(p.SteamId)); }, () => { });
        }
    }
}