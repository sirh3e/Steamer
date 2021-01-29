using Sirh3e.Steamer.Core.Parameter;

namespace Sirh3e.Steamer.Core.Parameters
{
    public interface ISteamerParameters
    {
        public bool TryAdd<TParameter>(string key, TParameter parameter)
            where TParameter : ISteamerParameter;

        public bool TryGetValue<TParameter>(string key, out TParameter parameter)
            where TParameter : ISteamerParameter;
    }
}