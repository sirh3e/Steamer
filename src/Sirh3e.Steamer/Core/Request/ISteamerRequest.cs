using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Core.Request
{
    //ToDo add get default Method from request
    public interface ISteamerRequest
    {
        public ISteamerMethod Method { get; }
    }
}