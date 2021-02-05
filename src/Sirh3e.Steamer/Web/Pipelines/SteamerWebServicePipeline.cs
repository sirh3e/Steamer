using System;
using Sirh3e.Steamer.Core.Extensions.Pipeline;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Pipelines.SteamerWebService.Handlers;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Pipelines
{
    public class
        SteamerWebServicePipeline<TSteamerResponse, TSteamerResponseModel> : SteamerPipeline<ISteamerRequest,
            TSteamerResponse>
        where TSteamerResponse : ISteamerResponse<TSteamerResponseModel>, new()
    {
        public SteamerWebServicePipeline(ISteamerWebService service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
            PipelineHandlers = request => request
                .AddHandler(new SteamerWebServiceRequestToUriPipelineHandler())
                .AddHandler(new SteamerWebServiceUriToHttpMessageResponsePipelineHandler(Service.HttpClientProvider))
                .AddHandler(new SteamerWebServiceHttpResponseMessageCatcherPipelineHandler())
                .AddHandler(new SteamerWebServiceHttpResponseMessageHandlerPipelineHandler())
                .AddHandler(
                    new SteamerWebServiceResponseModelPipelineHandler<TSteamerResponseModel>(Service.WebClient
                        .SerializerProvider))
                .AddHandler(new SteamerWebServiceResponsePipelineHandler<TSteamerResponse, TSteamerResponseModel>());
        }

        public ISteamerWebService Service { get; set; }
    }
}