using System.Net.Http;
using System.Text.Json;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Serializers.Json;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Examples.Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "YOUR API KEY"; //https://steamcommunity.com/dev/apikey
            var (service, client) = SteamerWebFactory.CreateByKey(key); //Default

            //Setup manual
            var authProvider = new SteamerAuthProvider.Builder().SetApiKey(key).Build();

            var serializerProvider = SteamerSerializerProvider.Factory.CreateDefault();//Default
            serializerProvider = new SteamerSerializerProvider
                    .SteamerBuilder()
                    .SetSerializer(new SteamerSystemTextJsonSerializer(new SteamerSystemTextJsonSerializerOptionsProvider(new JsonSerializerOptions())))
                    .Build();//Setup manual

            client = new SteamerWebClient.Builder().SetAuthProvider(authProvider).SetSerializerProvider(serializerProvider).Build();

            var httpClient = new HttpClient
            {
                //Setup your proxy
            };
            var httpClientProvider = new SteamerHttpClientProvider(httpClient);
            service = new SteamerWebService.Builder().SetWebClient(client).SetHttpClientProvider(httpClientProvider).Build();
        }
    }
}