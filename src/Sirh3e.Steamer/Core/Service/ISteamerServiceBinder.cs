using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Web.Errors;

namespace Sirh3e.Steamer.Core.Service
{
    public interface ISteamerServiceBinder<in TRequest, TResponse>
        where TRequest : ISteamerRequest
    {
        public Task<Result<TResponse, ISteamerWebError>> ExecuteAsync(TRequest request);
    }
}