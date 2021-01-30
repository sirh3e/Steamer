using System;
using System.Net;
using System.Net.Http;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Pipeline.Handlers
{
    public class SteamerHttpResponseMessageHandlerPipelineHandler : ISteamerPipelineHandler<(ISteamerRequest,
        HttpResponseMessage), (ISteamerRequest, Result<HttpResponseMessage, string>)>
    {
        public (ISteamerRequest, Result<HttpResponseMessage, string>) Process(
            (ISteamerRequest, HttpResponseMessage) input)
        {
            var (request, httpResponseMessage) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = httpResponseMessage ?? throw new ArgumentNullException(nameof(httpResponseMessage));

            if (httpResponseMessage.IsSuccessStatusCode.Equals(false))
                return (request,
                    Result<HttpResponseMessage, string>.Err(
                        $"{nameof(httpResponseMessage.IsSuccessStatusCode)} is not {true} it is '{false}'"));

            if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
                return (request,
                    Result<HttpResponseMessage, string>.Err(
                        $"{nameof(httpResponseMessage.StatusCode)} is not {HttpStatusCode.OK} it is '{httpResponseMessage.StatusCode}'"));

            return (request, Result<HttpResponseMessage, string>.Ok(httpResponseMessage));
        }
    }
}