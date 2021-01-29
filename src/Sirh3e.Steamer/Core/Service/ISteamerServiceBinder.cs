using Sirh3e.Steamer.Core.Reqeuest;

namespace Sirh3e.Steamer.Core.Service
{
    public interface ISteamerServiceBinder<in TRequest, out TResponse>
        where TRequest : ISteamerRequest
    {
        public TResponse Call(TRequest request);
    }
}