using System.Net.Http;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Errors
{
    public interface ISteamerWebError
    {
        public string Message { get; }
        public ISteamerRequest Request { get; set; }
        public Option<ISteamerWebError> CausedByError { get; }
        public Option<HttpResponseMessage> HttpResponseMessage { get; }
    }
}