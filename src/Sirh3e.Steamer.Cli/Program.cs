using System;
using System.Net.Http;
using Newtonsoft.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Net.Http;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Utilities.Serializer.Json;
using Sirh3e.Steamer.Web.Extensions.Requests.SteamUser;
using Sirh3e.Steamer.Web.Services.Web;

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
                    .SetSerializer(new NewtonsoftSerializer(JsonConvert.DeserializeObject))
                    .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());
            var service = new SteamerWebService(client, httpClientProvider);


            var response = client.SteamerUser.FriendList
                .SetKey(apiKey)
                .SetSteamId(76561198220146080)
                .Build()
                .ServiceExecute(service);

            var option = response.Model;

            option.Match(
                model =>
                {
                    model.FriendsList.Friends.ForEach(p =>
                        Console.WriteLine($"steamid: {p.SteamId} FriendSince: {p.FriendSince}"));
                },
                () => { });
        }
    }
}