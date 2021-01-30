using System;
using System.Net.Http;
using Newtonsoft.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Net.Http;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Utilities.Serializer.Json;
using Sirh3e.Steamer.Web.Extensions.Requests;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiKey = "8874C9EC68D98C99AA0F9CC6D35A7DCE";
            var client = new SteamerWebClient.Builder()
                .SetAuthProvider(new SteamerAuthProvider(apiKey))
                .SetSerializerProvider(new SteamerSerializerProvider.Builder()
                    .SetSerializer(new NewtonsoftSerializer(JsonConvert.DeserializeObject))
                    .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());

            var service = new SteamerWebService(client, httpClientProvider);


            var response = client.SteamerUser.PlayerBans
                .SetKey(apiKey) //ToDo add your key here
                .SetSteamIds(76561198220146080)
                .Build()
                .ServiceExecute(service);

            var builder = client.SteamerUser.PlayerBans.SetKey(apiKey).SetSteamIds(76561198220146080);
            var request = builder.Build();

            var steamerParameters = builder.Method.Parameters;

            //var response = service.Call(request); //ToDo rename it to Execute
            var option = response.Model;
            //model.Players.ForEach(p => Console.WriteLine($"steamid: {p.SteamId} vac: {p.VacBanned}"));

            option.Match(
                model => { model.Players.ForEach(p => Console.WriteLine($"steamid: {p.SteamId} vac: {p.VacBanned}")); },
                () => { });
        }
    }
}