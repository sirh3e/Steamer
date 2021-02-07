namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerStringParameter : SteamerParameter<string>
    {
        public SteamerStringParameter(string name, bool required = true, string value = "") : base(name, value,
            required)
        {
        }

        public override string GetValueFromQueryString() => Value;
    }
}