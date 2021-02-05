using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Serializer.Providers;

namespace Sirh3e.Steamer.Core.Response
{
    public class SteamerResponse : ISteamerResponse
    {
        public ISteamerRequest Request { get; set; }
        public ISteamerSerializerDataProvider Provider { get; }

        public Option<object> Model { get; set; }
    }

    public class SteamerResponse<TModel> : SteamerResponse, ISteamerResponse<TModel>
    {
        public new Option<TModel> Model { get; set; }
    }
}