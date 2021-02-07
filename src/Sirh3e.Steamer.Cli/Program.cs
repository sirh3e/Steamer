using System;
using System.Net.Http;
using System.Text.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Serializers.Json;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Request;
using Sirh3e.Steamer.SteamerWebService.Extensions.SteamUser.Response;

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
            var service = new SteamerWebService.SteamerWebService(client, httpClientProvider);

            var response = client.SteamerWebUser.SteamerWebResolveVanityUrl
                .SetKey(apiKey)
                .SetVanityUrl("sirh3e")
                .Build()
                .ServiceExecute(service)
                .RetryServiceExecute(service);

            var option = response.Model;
            option.Match(model => { Console.WriteLine(model.Response.SteamId); },
                         () => { Console.WriteLine("some error"); });
        }
    }
}