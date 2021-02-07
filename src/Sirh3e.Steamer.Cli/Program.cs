using System;
using System.Net.Http;
using System.Text.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Serializers.Json;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Extensions.Model;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Request;
using Sirh3e.Steamer.Web.Extensions.SteamUser.Response;

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

            var response = client.SteamUser.UserGroupList
                .SetKey(apiKey)
                .SetSteamId(76561198220146080)
                .Build()
                .ServiceExecute(service)
                .RetryServiceExecute(service);

            var option = response.Model;
            option.Match(responseModel =>
                         {
                             responseModel.GetModel().Groups.ForEach(g => Console.WriteLine($"{g.Gid}"));
                         },
                         () => { Console.WriteLine("some error"); });
        }
    }
}