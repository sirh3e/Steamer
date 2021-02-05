using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Service
{
    public interface ISteamerServiceBinder<in TRequest, out TResponse>
        where TRequest : ISteamerRequest
    {
        public TResponse Execute(TRequest request);
    }
}