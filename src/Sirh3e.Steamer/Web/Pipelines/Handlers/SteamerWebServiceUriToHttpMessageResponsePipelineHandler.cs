using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Internal.Extensions.System.Net.Http;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Internal.Rust;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceUriToHttpMessageResponsePipelineHandler<TSteamerRequest> :
        ISteamerPipelineHandler<Task<Result<(TSteamerRequest, Uri), ISteamerWebError>>,
            Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>>>
        where TSteamerRequest : ISteamerRequest
    {
        public
            SteamerWebServiceUriToHttpMessageResponsePipelineHandler(ISteamerHttpClientProvider httpClientProvider)
        {
            HttpClientProvider = httpClientProvider ?? throw new ArgumentNullException(nameof(httpClientProvider));
        }

        public ISteamerHttpClientProvider HttpClientProvider { get; set; }


        public async Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>>
            Process(Task<Result<(TSteamerRequest, Uri), ISteamerWebError>> task)
        {
            static Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError> OnErr(ISteamerWebError error)
                => error.FromErr<(TSteamerRequest, HttpResponseMessage)>();

            static Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError> OnOk(TSteamerRequest request,
                HttpResponseMessage response)
                => (request, response).FromOk();

            var result = await task;

            if ( result.IsErr )
                return OnErr(result.UnwrapErr());

            var (request, uri) = result.Unwrap();

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = uri ?? throw new ArgumentNullException(nameof(uri));

            var response =
                await HttpClientProvider.HttpClient.GetHttpResponseMessageAsync(request.Method.HttpMethod, uri);

            return OnOk(request, response);
        }
    }
}