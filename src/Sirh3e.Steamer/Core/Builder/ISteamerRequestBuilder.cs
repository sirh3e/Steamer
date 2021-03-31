using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Builder
{
    public interface ISteamerRequestBuilder<out TRequest>
        where TRequest : ISteamerRequest
    {
        public TRequest Request { get; }
        public TRequest Build();
        public TRequest Build(ISteamerParameters parameters);
    }
}