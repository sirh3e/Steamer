﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class SteamerWebServiceHttpResponseMessageCatcherPipelineHandler<TSteamerRequest> :
        ISteamerPipelineHandler<(TSteamerRequest, Task<HttpResponseMessage>), (TSteamerRequest, HttpResponseMessage)>
        where TSteamerRequest : ISteamerRequest
    {
        public (TSteamerRequest, HttpResponseMessage) Process((TSteamerRequest, Task<HttpResponseMessage>) input)
            => ProcessAsync(input).Result;

        public async Task<(TSteamerRequest, HttpResponseMessage)> ProcessAsync(
            (TSteamerRequest, Task<HttpResponseMessage>) input)
        {
            var (request, taskHttpResponseMessage) = input;

            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = taskHttpResponseMessage ?? throw new ArgumentNullException(nameof(taskHttpResponseMessage));

            var httpResponseMessage = await taskHttpResponseMessage;

            return (request, httpResponseMessage);
        }
    }
}