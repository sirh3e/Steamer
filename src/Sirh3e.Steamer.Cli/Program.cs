using System;
using Newtonsoft.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Client;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Utilities.Serializer.Json;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new SteamerWebClient.Builder()
                .SetClient(new SteamerClient.Builder()
                    .SetAuthProvider(new SteamerAuthProvider(""))
                    .Build()
                )
                .SetProvider(new SteamerSerializerProvider.Builder()
                    .SetSerializer(new NewtonsoftSerializer(JsonConvert.DeserializeObject))
                    .Build())
                .Build();

            var service = new SteamerWebService(client);

            var request = client.SteamUser.PlayerBans
                .SetSteamIds(1, 2, 4, 8)
                .SetSteamIds()
                .SetSteamIds()
                .Build();
            //.ServiceCall(service);

            var response = service.Call(request);
            var model = response.Model;

            model.Players.ForEach(p => Console.WriteLine(p.SteamId));
        }
    }
}