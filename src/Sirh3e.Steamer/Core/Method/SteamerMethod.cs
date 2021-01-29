using System;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Core.Method
{
    public class SteamerMethod : ISteamerMethod
    {
        public SteamerMethod(ISteamerInterface @interface, string name, ulong version,
            ISteamerParameters parameters)
        {
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Version = version;
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public ISteamerInterface Interface { get; }
        public string Name { get; }
        public ulong Version { get; }
        public ISteamerParameters Parameters { get; }
    }
}