using System;
using System.Threading.Tasks;
using Sirh3e.Rust.Option;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Internal.Rust;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceResponsePipelineHandler<TSteamerRequest, TSteamerResponse, TSteamerResponseModel> :
        ISteamerPipelineHandler<Task<Result<(TSteamerRequest, Option<TSteamerResponseModel>), ISteamerWebError>>,
            Task<Result<TSteamerResponse, ISteamerWebError>>>
        where TSteamerResponse : ISteamerResponse<TSteamerRequest, TSteamerResponseModel>, new()
        where TSteamerRequest : ISteamerRequest
    {
        public async Task<Result<TSteamerResponse, ISteamerWebError>> Process(
            Task<Result<(TSteamerRequest, Option<TSteamerResponseModel>), ISteamerWebError>> task)
        {
            static Result<TSteamerResponse, ISteamerWebError> OnErr(ISteamerWebError error)
                => error.FromErr<TSteamerResponse>();

            static Result<TSteamerResponse, ISteamerWebError> OnOk(TSteamerResponse response)
                => response.FromOk();

            var result = await task;
            if ( result.IsErr )
                return OnErr(result.UnwrapErr());

            var (request, model) = result.Unwrap();

            if ( model.IsNone )
                return OnErr(new SteamerWebError { Message = $"'{nameof(model)}' is '{nameof(model.IsNone)}' must be '{nameof(model.IsSome)}' maybe could not serialize response", Request = request });

            _ = request ?? throw new ArgumentNullException(nameof(request));

            var response = new TSteamerResponse { Model = model, Request = request };

            return OnOk(response);
        }
    }
}