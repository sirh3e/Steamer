using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Net.Http;

namespace Sirh3e.Steamer.Core.Pipeline.Handlers
{
    public class SteamerUriToResponsePipelineHandler : ISteamerPipelineHandler<(ISteamerRequest, Uri), (ISteamerRequest,
        Task<HttpResponseMessage>)>
    {
        public SteamerUriToResponsePipelineHandler(ISteamerHttpClientProvider httpClientProvider)
        {
            HttpClientProvider = httpClientProvider ?? throw new ArgumentNullException(nameof(httpClientProvider));
        }

        public ISteamerHttpClientProvider HttpClientProvider { get; set; }

        public (ISteamerRequest, Task<HttpResponseMessage>) Process((ISteamerRequest, Uri) input)
        {
            var (request, uri) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = uri ?? throw new ArgumentNullException(nameof(uri));

            //ToDo check for other then just get, like post, put etc
            var responseTask = HttpClientProvider.HttpClient.GetAsync(uri);

            return (request, responseTask);
        }
    }
}