using System;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;

namespace Sirh3e.Steamer.Web.Pipelines.SteamerWebService.Handlers
{
    public class SteamerResponsePipelineHandler<TSteamerResponse, TSteamerResponseModel> : ISteamerPipelineHandler<(
        ISteamerRequest, Option<TSteamerResponseModel>), TSteamerResponse>
        where TSteamerResponse : ISteamerResponse<TSteamerResponseModel>, new()
    {
        public TSteamerResponse Process((ISteamerRequest, Option<TSteamerResponseModel>) input)
        {
            var (request, model) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));

            return new TSteamerResponse
            {
                Model = model,
                Request = request
            };
        }
    }
}