using System.Collections.Generic;

using Sirh3e.Steamer.Core.Parameter;

namespace Sirh3e.Steamer.Core.Parameters {
    public interface ISteamerParameters : IEnumerable<ISteamerParameter> {
        public bool TryAdd<TParameter>(string key, TParameter parameter)
            where TParameter : ISteamerParameter;

        public bool TryGetValue<TParameter>(string key, out TParameter parameter)
            where TParameter : ISteamerParameter;

        public void SetValue<TValue>(string key, TValue value);
    }
}