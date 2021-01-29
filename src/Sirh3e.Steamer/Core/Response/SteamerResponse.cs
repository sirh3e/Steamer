using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Utilities.Serializer;

namespace Sirh3e.Steamer.Core.Response
{
    public class SteamerResponse : ISteamerResponse
    {
        public ISteamerRequest Request { get; set; }
        public ISteamerSerializerDataProvider Provider { get; }
        public object Model { get; set; } = new();
    }

    public class SteamerResponse<TModel> : SteamerResponse, ISteamerResponse<TModel>
    {
        public new TModel Model { get; set; }
    }
}