using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Rust.Option;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Internal.Rust;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceHttpResponseMessageHandlerPipelineHandler<TSteamerRequest> :
        ISteamerPipelineHandler<Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>>,
            Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>>>
        where TSteamerRequest : ISteamerRequest
    {
        public async Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>> Process(
            Task<Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError>> task)
        {
            static Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError> OnOk(
                (TSteamerRequest, HttpResponseMessage) ok)
                => ok.FromOk();

            static Result<(TSteamerRequest, HttpResponseMessage), ISteamerWebError> OnError(
                HttpResponseMessage responseMessage, ISteamerRequest request, string message)
            {
                return new SteamerWebError
                {
                    Message = message,
                    Request = request,
                    HttpResponseMessage = Option<HttpResponseMessage>.Some(responseMessage)
                }.FromErr<(TSteamerRequest, HttpResponseMessage)>();
            }

            var result = await task;
            if ( result.IsErr )
                return result;

            var (request, message) = result.Unwrap();

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = message ?? throw new ArgumentNullException(nameof(message));

            if ( message.IsSuccessStatusCode.Equals(false) )
                return OnError(message, request,
                    $"{nameof(message.IsSuccessStatusCode)} is not {true} it is '{false}'");

            return message.StatusCode == HttpStatusCode.OK
                ? OnOk((request, message))
                : OnError(message, request,
                    $"{nameof(message.StatusCode)} is not {HttpStatusCode.OK} it is '{message.StatusCode}'");
        }
    }
}