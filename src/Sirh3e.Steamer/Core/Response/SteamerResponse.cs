using Sirh3e.Steamer.Core.Reqeuest;

namespace Sirh3e.Steamer.Core.Response
{
    public class SteamerResponse : ISteamerResponse
    {
        public ISteamerRequest Request { get; set; }
        public object Model { get; set; } = new();
    }

    public class SteamerResponse<TModel> : SteamerResponse, ISteamerResponse<TModel>
    {
        public new TModel Model { get; set; }
    }
}