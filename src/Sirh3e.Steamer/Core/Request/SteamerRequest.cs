using System;

using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Core.Request {
    public class SteamerRequest : ISteamerRequest {
        public SteamerRequest(ISteamerMethod method) {
            Method = method ?? throw new ArgumentNullException(nameof(method));
        }

        public ISteamerMethod Method { get; }
    }
}