using System;

namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerStringParameter : ISteamerParameter<string>
    {
        public SteamerStringParameter(string name, bool required = true, string value = "")
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Required = required;
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public bool Required { get; }
        public string Name { get; }
        public string Value { get; private set; }

        public string GetValueFromQueryString()
        {
            return Value;
        }

        object ISteamerParameter.Value
        {
            get => Value;
            set => Value = value as string;
        }

        public void Deconstruct(out bool required, out string name, out string value)
        {
            required = Required;
            name = Name;
            value = Value;
        }

        public void Deconstruct(out bool required, out string name, out object value)
        {
            Deconstruct(out required, out name, out string tmp);

            value = tmp;
        }
    }
}