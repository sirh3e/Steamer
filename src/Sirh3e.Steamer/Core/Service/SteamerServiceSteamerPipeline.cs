using System;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Pipeline.Handlers;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Core.Service
{
    public class
        SteamerServiceSteamerPipeline<TSteamerResponse, TSteamerResponseModel> : SteamerPipeline<ISteamerRequest,
            TSteamerResponse>
        where TSteamerResponse : ISteamerResponse<TSteamerResponseModel>, new()
    {
        public SteamerServiceSteamerPipeline(ISteamerWebService service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
            PipelineHandlers = request => request
                .AddHandler(new SteamerRequestToUriPipelineHandler())
                .AddHandler(new SteamerUriToResponsePipelineHandler(Service.HttpClientProvider))
                .AddHandler(new SteamerHttpResponseMessageCatcherPipelineHandler())
                .AddHandler(new SteamerHttpResponseMessageHandlerPipelineHandler())
                .AddHandler(
                    new SteamerResponseModelPipelineHandler<TSteamerResponseModel>(Service.WebClient.SerializerProvider))
                .AddHandler(new SteamerResponsePipelineHandler<TSteamerResponse, TSteamerResponseModel>());
        }

        public ISteamerWebService Service { get; set; }
    }
}