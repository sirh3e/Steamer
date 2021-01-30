using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Utilities.Serializer;

namespace Sirh3e.Steamer.Core.Response
{
    public interface ISteamerResponse
    {
        public ISteamerRequest Request { get; set; }
        public ISteamerSerializerDataProvider Provider { get; }
        public Option<object> Model { get; set; }
    }

    public interface ISteamerResponse<TModel> : ISteamerResponse
    {
        public new Option<TModel> Model { get; set; }
    }
}