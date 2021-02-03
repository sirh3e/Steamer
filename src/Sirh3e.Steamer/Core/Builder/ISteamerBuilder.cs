using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Builder {
    public interface ISteamerBuilder<out TRequest>
        where TRequest : ISteamerRequest {
        public ISteamerInterface Interface { get; }
        public ISteamerMethod Method { get; }
        public ISteamerMethod GetDefaultMethod();

        public TRequest Build();
    }
}