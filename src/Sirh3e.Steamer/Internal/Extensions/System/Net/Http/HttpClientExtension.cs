using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Steamer.Core.Net.Http.Methods;

namespace Sirh3e.Steamer.Internal.Extensions.System.Net.Http
{
    internal static class SteamerHttpClientExtension
    {
        internal static Task<HttpResponseMessage> GetHttpResponseMessageAsync(this HttpClient client,
            ISteamerHttpMethod method,
            Uri uri)
        {
            _ = client ?? throw new ArgumentNullException(nameof(client));
            _ = method ?? throw new ArgumentNullException(nameof(method));
            _ = uri ?? throw new ArgumentNullException(nameof(uri));

            return method.GetHttpResponseMessageAsync(client, uri);
        }
    }
}