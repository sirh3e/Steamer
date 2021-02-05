using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Core.Response
{
    public interface ISteamerResponse
    {
        public ISteamerRequest Request { get; set; } //Change Request Type
        public ISteamerSerializerDataProvider Provider { get; }
        public Option<object> Model { get; set; }
    }

    public interface ISteamerResponse<TModel> : ISteamerResponse
    {
        public new Option<TModel> Model { get; set; }
    }
}