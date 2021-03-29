using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceResponsePipelineHandler<TSteamerRequest, TSteamerResponse, TSteamerResponseModel> :
        ISteamerPipelineHandler<(TSteamerRequest, Option<TSteamerResponseModel>), TSteamerResponse>
        where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
        where TSteamerRequest : ISteamerRequest
    {
        public TSteamerResponse Process((TSteamerRequest, Option<TSteamerResponseModel>) input)
            => ProcessAsync(input).Result;

        public async Task<TSteamerResponse> ProcessAsync((TSteamerRequest, Option<TSteamerResponseModel>) input)
        {
            var (request, model) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));

            return new TSteamerResponse { Model = model, Request = request };
        }
    }
}