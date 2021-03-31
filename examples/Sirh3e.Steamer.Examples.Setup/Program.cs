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
            //Create a api key: https://steamcommunity.com/dev/apikey keep is secure
            var key = "YOUR API KEY";

            //Default setup
            {
                var (service, client) = SteamerWebFactory.CreateByKey(key); //Default
            }

            //Manual setup
            {
                var authProvider = new SteamerAuthProvider.Builder()
                    .SetApiKey(key)
                    .Build();

                //Default setup
                var serializerProvider = SteamerSerializerProvider.Factory.CreateDefault();

                //Manual setup
                serializerProvider = new SteamerSerializerProvider.SteamerBuilder()
                        .SetSerializer(new SteamerSystemTextJsonSerializer(new SteamerSystemTextJsonSerializerOptionsProvider(new JsonSerializerOptions())))
                        .Build(); //Setup manual

                var client = new SteamerWebClient.Builder()
                    .SetAuthProvider(authProvider)
                    .SetSerializerProvider(serializerProvider)
                    .Build();

                //Maybe setup for proxy or other things
                var httpClient = new HttpClient();
                var httpClientProvider = new SteamerHttpClientProvider.Builder()
                    .SetHttpClient(httpClient)
                    .Build();

                var service = new SteamerWebService.Builder()
                    .SetWebClient(client)
                    .SetHttpClientProvider(httpClientProvider)
                    .Build();
            }
        }
    }
}