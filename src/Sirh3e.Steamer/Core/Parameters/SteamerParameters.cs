using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirh3e.Steamer.Core.Parameter;

namespace Sirh3e.Steamer.Core.Parameters
{
    public class SteamerParameters : ISteamerParameters
    {
        public SteamerParameters(params ISteamerParameter[] parameters)
        {
            if ( parameters.Any(parameter => TryAdd(parameter.Name, parameter).Equals(false)) )
                throw new NotImplementedException();
        }

        private IDictionary<string, ISteamerParameter> Parameters { get; } =
            new Dictionary<string, ISteamerParameter>();

#if NETSTANDARD2_1_OR_GREATER
        public bool TryAdd<TParameter>(string key, TParameter parameter)
            where TParameter : ISteamerParameter
            => Parameters.TryAdd(key, parameter);
#else
        public bool TryAdd<TParameter>(string key, TParameter parameter)
            where TParameter : ISteamerParameter
        {
            if ( Parameters.ContainsKey(key) ) return false;
            Parameters.Add(key, parameter);
            return true;
        } 
#endif

        public bool TryGetValue<TParameter>(string key, out TParameter parameter)
            where TParameter : ISteamerParameter
        {
            var result = Parameters.TryGetValue(key, out var _parameter);
            parameter = (TParameter)_parameter;

            return result;
        }

        public void SetValue<TValue>(string key, TValue value)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            if ( Parameters.TryGetValue(key, out var parameter) )
                parameter.Value = value;
        }

        public IEnumerator<ISteamerParameter> GetEnumerator()
            => Parameters.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}