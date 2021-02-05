using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Core.Request
{
    public interface ISteamerRequest
    {
        public ISteamerMethod Method { get; }
    }
}