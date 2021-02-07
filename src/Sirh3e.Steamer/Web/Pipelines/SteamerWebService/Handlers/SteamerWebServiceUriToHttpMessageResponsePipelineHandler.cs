using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Extensions.Internal.System.Net.Http;

namespace Sirh3e.Steamer.Web.Pipelines.SteamerWebService.Handlers
{
    public class SteamerWebServiceUriToHttpMessageResponsePipelineHandler<TSteamerRequest> :
        ISteamerPipelineHandler<(TSteamerRequest, Uri), (TSteamerRequest, Task<HttpResponseMessage>)>
        where TSteamerRequest : ISteamerRequest
    {
        public
            SteamerWebServiceUriToHttpMessageResponsePipelineHandler(ISteamerHttpClientProvider httpClientProvider) =>
            HttpClientProvider = httpClientProvider ?? throw new ArgumentNullException(nameof(httpClientProvider));

        public ISteamerHttpClientProvider HttpClientProvider { get; set; }

        public (TSteamerRequest, Task<HttpResponseMessage>) Process((TSteamerRequest, Uri) input)
        {
            var (request, uri) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = uri ?? throw new ArgumentNullException(nameof(uri));

            //ToDo check for other then just get, like post, put etc
            var responseTask = HttpClientProvider.HttpClient.GetHttpResponseMessageAsync(request.Method.HttpMethod, uri);

            return (request, responseTask);
        }
    }
}