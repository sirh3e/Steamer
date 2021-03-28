using System;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Internal.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Web.Pipelines.Handlers;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Pipelines
{
    public class
        SteamerWebServicePipeline<TSteamerRequest, TSteamerResponse, TSteamerResponseModel> : SteamerPipeline<
            TSteamerRequest, TSteamerResponse>
        where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
        where TSteamerRequest : ISteamerRequest
    {
        public SteamerWebServicePipeline(ISteamerWebService service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
            PipelineHandlers = request => request
                .AddHandler(new SteamerWebServiceRequestToUriPipelineHandler<TSteamerRequest>(Service.WebClient.AuthProvider))
                .AddHandler(new SteamerWebServiceUriToHttpMessageResponsePipelineHandler<TSteamerRequest>(Service
                    .HttpClientProvider))
                .AddHandler(new SteamerWebServiceHttpResponseMessageCatcherPipelineHandler<TSteamerRequest>())
                .AddHandler(new SteamerWebServiceHttpResponseMessageHandlerPipelineHandler<TSteamerRequest>())
                .AddHandler(new SteamerWebServiceResponseModelPipelineHandler<TSteamerRequest, TSteamerResponseModel
                >(Service
                    .WebClient
                    .SerializerProvider))
                .AddHandler(new SteamerWebServiceResponsePipelineHandler<TSteamerRequest, TSteamerResponse,
                    TSteamerResponseModel>());
        }

        public ISteamerWebService Service { get; set; }
    }
}