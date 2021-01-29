using System;
using System.Collections.Generic;
using System.Linq;
using Sirh3e.Steamer.Core.Parameter;

namespace Sirh3e.Steamer.Core.Parameters
{
    public class SteamerParameters : ISteamerParameters
    {
        protected Dictionary<string, ISteamerParameter> Parameters { get; } = new();
        public SteamerParameters(params ISteamerParameter[] parameters)
        {
            if (parameters.Any(parameter => TryAdd(parameter.Name, parameter).Equals(false)))
            {
                throw new NotImplementedException();
            }
        }

        public bool TryAdd<TParameter>(string key, TParameter parameter)
            where TParameter : ISteamerParameter
        {
            return Parameters.TryAdd(key, parameter);
        }

        public bool TryGetValue<TParameter>(string key, out TParameter parameter)
            where TParameter : ISteamerParameter
        {
            var result = Parameters.TryGetValue(key, out var _parameter);
            parameter = (TParameter)_parameter;

            return result;
        }
    }
}