namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerI32Parameter : SteamerParameter<int>
    {
        public SteamerI32Parameter(string name, bool required = true, int value = 0) : base(name, value, required)
        {
        }

        public override string GetValueFromQueryString() => Value.ToString();
    }
}