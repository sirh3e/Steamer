namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerUlongParameter : SteamerParameter<ulong>
    {
        public SteamerUlongParameter(string name, bool required = true, ulong value = 0) : base(name, value, required)
        {
        }

        public override string GetValueFromQueryString()
            => Value.ToString();
    }
}