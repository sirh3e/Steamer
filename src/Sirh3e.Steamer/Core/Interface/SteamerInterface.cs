using System;

namespace Sirh3e.Steamer.Core.Interface
{
    public class SteamerInterface : ISteamerInterface
    {
        public SteamerInterface(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

        public string Name { get; }
    }
}