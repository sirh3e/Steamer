using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sirh3e.Steamer.Core.Net.Http.Methods
{
    public interface ISteamerHttpMethod
    {
        public Task<HttpResponseMessage> GetHttpResponseMessageAsync(HttpClient client, Uri uri);
    }
}