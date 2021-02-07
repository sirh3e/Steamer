using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Response
{
    public class SteamerResponse<TRequest, TModel> : ISteamerResponse<TRequest, TModel>
        where TRequest : ISteamerRequest
    {
        public TRequest Request { get; init; }
        public Option<TModel> Model { get; init; }
    }
}