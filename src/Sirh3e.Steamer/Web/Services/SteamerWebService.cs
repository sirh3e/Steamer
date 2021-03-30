using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Pipelines;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public SteamerWebService(ISteamerWebClient webClient, ISteamerHttpClientProvider httpClientProvider)
        {
            WebClient = webClient ?? throw new ArgumentNullException(nameof(webClient));
            HttpClientProvider = httpClientProvider ?? throw new ArgumentNullException(nameof(httpClientProvider));
        }

        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }

        public void Dispose()
            => HttpClientProvider.HttpClient.Dispose();

        public async Task<Result<TOutput, ISteamerWebError>> MapAsync<TInput, TOutput>(
            Task<Result<TInput, ISteamerWebError>> task)
            where TInput : TOutput, new()
            => (await task).Match(response => Result<TOutput, ISteamerWebError>.Ok(response),
                Result<TOutput, ISteamerWebError>.Err);

        public Task<Result<TSteamerResponse, ISteamerWebError>> ExecuteAsync<TSteamerRequest, TSteamerResponse,
            TSteamerResponseModel>(
            TSteamerRequest request,
            TSteamerResponse response,
            Func<TSteamerResponseModel> model)
            where TSteamerRequest : ISteamerRequest
            where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
            => ExecuteAsync<TSteamerRequest, TSteamerResponse, TSteamerResponseModel>(request);

        public Task<Result<TSteamerResponse, ISteamerWebError>> ExecuteAsync<TSteamerRequest, TSteamerResponse,
            TSteamerResponseModel>(
            TSteamerRequest request)
            where TSteamerRequest : ISteamerRequest
            where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
            => CreatePipeline<TSteamerRequest, TSteamerResponse, TSteamerResponseModel>().Process(request);

        private SteamerWebServicePipeline<TSteamerRequest, TSteamerResponse, TSteamerResponseModel> CreatePipeline
            <TSteamerRequest, TSteamerResponse, TSteamerResponseModel>()
            where TSteamerRequest : ISteamerRequest
            where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
            => new(this);
    }
}