using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Rust.Option;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Internal.Rust;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceResponseModelPipelineHandler<TSteamerRequest, TResponseModel> :
        ISteamerPipelineHandler<Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>>,
            Task<Result<(TSteamerRequest, Option<TResponseModel>), ISteamerWebError>>>
        where TSteamerRequest : ISteamerRequest
    {
        public SteamerWebServiceResponseModelPipelineHandler(ISteamerSerializerProvider serializerProvider)
        {
            SerializerProvider = serializerProvider ?? throw new ArgumentNullException(nameof(serializerProvider));
        }

        public ISteamerSerializerProvider SerializerProvider { get; set; }

        public async Task<Result<(TSteamerRequest, Option<TResponseModel>), ISteamerWebError>> Process(
            Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>> task)
        {
            static Result<(TSteamerRequest, Option<TResponseModel>), ISteamerWebError> OnErr(ISteamerWebError error)
                => error.FromErr<(TSteamerRequest, Option<TResponseModel>)>();

            static Result<(TSteamerRequest, Option<TResponseModel>), ISteamerWebError> OnOk(TSteamerRequest request,
                Option<TResponseModel> model)
                => (request, model).FromOk();

            var result = await task;
            if ( result.IsErr )
                return OnErr(result.UnwrapErr());

            var (request, response) = result.Unwrap();

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = response ?? throw new ArgumentNullException(nameof(response));

            var content = await response.Content.ReadAsStringAsync();
            var @object =
                SerializerProvider.Serializer.Serialize<TResponseModel>(
                    new SteamerSerializerStringDataProvider(content));

            var model = @object is null ? Option<TResponseModel>.None : Option<TResponseModel>.Some(@object);

            return OnOk(request, model);
        }
    }
}