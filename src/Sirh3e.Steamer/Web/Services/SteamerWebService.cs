using System;
using System.IO;
using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Core.Reqeuest;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;

namespace Sirh3e.Steamer.Web.Services
{
    public class SteamerWebService : ISteamerWebService
    {
        public SteamerWebService(ISteamerWebClient client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public ISteamerWebClient Client { get; }

        private TResponse Call<TRequest, TResponse>(TRequest request)
            where TRequest : ISteamerRequest
            where TResponse : ISteamerResponse, new()
        {

            var response = new TResponse
            {
                Request = request,
                //Provider = 
            };

            return response;
        }

        public IPlayerBansResponse Call(IPlayerBansRequest request)
        {
            var response = Call<IPlayerBansRequest, PlayerBansResponse>(request);

            var data = File
                .OpenText(
                    @"D:\Programming\git\github\users\sirh3e\repositories\csharp\Steamer\src\Sirh3e.Steamer.Cli\NewFile1.txt")
                .ReadToEnd();

            response.Model = Serialize(response.Model, response.Provider);

            return response;
        }

        private T Serialize<T>(T model, ISteamerSerializerDataProvider provider)
        {
            _ = provider ?? throw new ArgumentNullException(nameof(provider));

            return Client.SerializerProvider.Serializer.Serialize<T>(provider);
        }
    }
}