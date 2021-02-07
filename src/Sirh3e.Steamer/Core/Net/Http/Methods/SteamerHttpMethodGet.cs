using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sirh3e.Steamer.Core.Net.Http.Methods
{
    public class SteamerHttpMethodGet : ISteamerHttpMethod
    {
        public Task<HttpResponseMessage> GetHttpResponseMessageAsync(HttpClient client, Uri uri)
        {
            _ = client ?? throw new ArgumentNullException(nameof(client));
            _ = uri ?? throw new ArgumentNullException(nameof(uri));

            return client.GetAsync(uri);
        }
    }
}