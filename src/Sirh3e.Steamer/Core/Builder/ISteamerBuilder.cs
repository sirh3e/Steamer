using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Builder
{
    public interface ISteamerBuilder<TRequest>
        where TRequest : ISteamerRequest
    {
        public ISteamerMethod Method { get; }

        public TRequest Build();
    }
}