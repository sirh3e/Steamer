using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Response
{
    public interface ISteamerResponse<TRequest, TModel>
        where TRequest : ISteamerRequest
    {
        public TRequest Request { get; set; } //Change Request Type
        public Option<TModel> Model { get; set; }
    }
}