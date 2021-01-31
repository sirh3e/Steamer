﻿using System;
using System.Net.Http;
using Newtonsoft.Json;
using Sirh3e.Steamer.Core.Auth;
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
            var apiKey = "";
            var client = new SteamerWebClient.Builder()
                .SetAuthProvider(new SteamerAuthProvider(apiKey))
                .SetSerializerProvider(new SteamerSerializerProvider.Builder()
                    .SetSerializer(new NewtonsoftSerializer(JsonConvert.DeserializeObject))
                    .Build())
                .Build();

            var httpClientProvider = new SteamerHttpClientProvider(new HttpClient());
            var service = new SteamerWebService(client, httpClientProvider);


            var response = client.SteamerUser.PlayerSummaries
                .SetKey(apiKey)
                .SetSteamIds(76561198220146080)
                .Build()
                .ServiceExecute(service);

            var option = response.Model;

            option.Match(
                model =>
                {
                    model.Response.Players.ForEach(p => Console.WriteLine($"steamid: {p.SteamId} vac: {p.Avatar}"));
                },
                () => { });
        }
    }
}