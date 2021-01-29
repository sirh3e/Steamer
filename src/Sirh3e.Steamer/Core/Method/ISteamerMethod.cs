using System.Net.Http;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Core.Method
{
    public interface ISteamerMethod
    {
        public HttpMethod HttpMethod { get; }
        public ISteamerInterface Interface { get; }
        public string Name { get; }
        public ulong Version { get; }

        public ISteamerParameters Parameters { get; }
    }
}