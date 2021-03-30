using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Internal.Extensions.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Pipelines.Handlers;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Pipelines
{
    public class
        SteamerWebServicePipeline<TSteamerRequest, TSteamerResponse, TSteamerResponseModel> : SteamerPipeline<
            TSteamerRequest, Task<Result<TSteamerResponse, ISteamerWebError>>>
        where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
        where TSteamerRequest : ISteamerRequest
    {
        public ISteamerWebService Service { get; }

        public SteamerWebServicePipeline(ISteamerWebService service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
            PipelineHandlers = request => request
                .AddHandler(
                    new SteamerWebServiceRequestToUriPipelineHandler<TSteamerRequest>(Service.WebClient.AuthProvider))
                .AddHandler(
                    new SteamerWebServiceUriToHttpMessageResponsePipelineHandler<TSteamerRequest>(
                        Service.HttpClientProvider))
                .AddHandler(new SteamerWebServiceHttpResponseMessageHandlerPipelineHandler<TSteamerRequest>())
                .AddHandler(
                    new SteamerWebServiceResponseModelPipelineHandler<TSteamerRequest, TSteamerResponseModel>(
                        Service.WebClient.SerializerProvider))
                .AddHandler(
                    new SteamerWebServiceResponsePipelineHandler<TSteamerRequest, TSteamerResponse,
                        TSteamerResponseModel>());
        }
    }
}