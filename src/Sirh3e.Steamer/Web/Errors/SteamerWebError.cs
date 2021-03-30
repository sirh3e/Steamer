using System.Net.Http;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Errors
{
    public class SteamerWebError : ISteamerWebError
    {
        public string Message { get; init; }
        public ISteamerRequest Request { get; set; }

        public Option<ISteamerWebError> CausedByError { get; init; }
        public Option<HttpResponseMessage> HttpResponseMessage { get; init; }
    }
}