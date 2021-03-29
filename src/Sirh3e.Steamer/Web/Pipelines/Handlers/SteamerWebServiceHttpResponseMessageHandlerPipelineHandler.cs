using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceHttpResponseMessageHandlerPipelineHandler<TSteamerRequest> :
        ISteamerPipelineHandler<(TSteamerRequest, HttpResponseMessage), (TSteamerRequest,
            Result<HttpResponseMessage, string>)>
        where TSteamerRequest : ISteamerRequest
    {
        public (TSteamerRequest, Result<HttpResponseMessage, string>) Process(
            (TSteamerRequest, HttpResponseMessage) input)
            => ProcessAsync(input).Result;

        public async Task<(TSteamerRequest, Result<HttpResponseMessage, string>)> ProcessAsync(
            (TSteamerRequest, HttpResponseMessage) input)
        {
            var (request, httpResponseMessage) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = httpResponseMessage ?? throw new ArgumentNullException(nameof(httpResponseMessage));

            if ( httpResponseMessage.IsSuccessStatusCode.Equals(false) )
                return (request,
                    Result<HttpResponseMessage, string>
                        .Err($"{nameof(httpResponseMessage.IsSuccessStatusCode)} is not {true} it is '{false}'"));

            if ( httpResponseMessage.StatusCode != HttpStatusCode.OK )
                return (request,
                    Result<HttpResponseMessage, string>
                        .Err(
                            $"{nameof(httpResponseMessage.StatusCode)} is not {HttpStatusCode.OK} it is '{httpResponseMessage.StatusCode}'"));

            return (request, Result<HttpResponseMessage, string>.Ok(httpResponseMessage));
        }
    }
}