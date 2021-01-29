using Sirh3e.Steamer.Core.Reqeuest;

namespace Sirh3e.Steamer.Core.Response
{
    public interface ISteamerResponse
    {
        public ISteamerRequest Request { get; set; }
        public object Model { get; set; }
    }

    public interface ISteamerResponse<TModel> : ISteamerResponse
    {
        public new TModel Model { get; set; }
    }
}