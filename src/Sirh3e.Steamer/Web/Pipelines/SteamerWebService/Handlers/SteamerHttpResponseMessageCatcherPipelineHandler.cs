using System;
using System.Net.Http;
using System.Threading.Tasks;

using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Pipelines.SteamerWebService.Handlers {
    public class SteamerHttpResponseMessageCatcherPipelineHandler : ISteamerPipelineHandler<(ISteamerRequest,
        Task<HttpResponseMessage>), (ISteamerRequest, HttpResponseMessage)> {
        public (ISteamerRequest, HttpResponseMessage) Process((ISteamerRequest, Task<HttpResponseMessage>) input) {
            var (request, taskHttpResponseMessage) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = taskHttpResponseMessage ?? throw new ArgumentNullException(nameof(taskHttpResponseMessage));

            taskHttpResponseMessage.Wait();
            var httpResponseMessage = taskHttpResponseMessage.Result;

            return (request, httpResponseMessage);
        }
    }
}