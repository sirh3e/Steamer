using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Rust.Option;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Web.Pipelines.SteamerWebService.Handlers
{
    public class SteamerWebServiceResponseModelPipelineHandler<TSteamerRequest, TResponseModel> :
        ISteamerPipelineHandler<(TSteamerRequest, Result<HttpResponseMessage, string>), (TSteamerRequest,
            Option<TResponseModel>)>
        where TSteamerRequest : ISteamerRequest
    {
        public SteamerWebServiceResponseModelPipelineHandler(ISteamerSerializerProvider serializerProvider)
        {
            SerializerProvider = serializerProvider ?? throw new ArgumentNullException(nameof(serializerProvider));
        }

        public ISteamerSerializerProvider SerializerProvider { get; set; }

        public (TSteamerRequest, Option<TResponseModel>) Process(
            (TSteamerRequest, Result<HttpResponseMessage, string>) input)
        {
            var (request, result) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));

            var option = result.Match(async ok =>
            {
                var content = await ok.Content.ReadAsStringAsync();

                var model = SerializerProvider.Serializer.Serialize<TResponseModel>(
                    new SteamerSerializerStringDataProvider(content));

                return model is not null ? Option<TResponseModel>.Some(model) : Option<TResponseModel>.None;
            }, async err => await Task.Run(() => Option<TResponseModel>.None));

            option.Wait();
            var model = option.Result;

            return (request, model);
        }
    }
}