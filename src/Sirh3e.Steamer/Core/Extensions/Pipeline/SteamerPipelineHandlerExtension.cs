using System;
using Sirh3e.Steamer.Core.Pipeline;

namespace Sirh3e.Steamer.Core.Extensions.Pipeline
{
    public static class SteamerPipelineHandlerExtension
    {
        public static TOutput AddHandler<TInput, TOutput>(this TInput input,
                                                          ISteamerPipelineHandler<TInput, TOutput> handler)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));
            _ = handler ?? throw new ArgumentNullException(nameof(input));

            return handler.Process(input);
        }
    }
}