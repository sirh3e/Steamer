using System;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Response
{
    public interface ISteamerResponse<TRequest, TModel> : ISteamerResponse<TModel>
        where TRequest : ISteamerRequest
    {
        public TRequest Request { get; init; }
    }

    public interface ISteamerResponse<TModel>
    {
        public Option<TModel> Model { get; init; }
#if NETSTANDARD2_1_OR_GREATER
       public void Match(Action<TModel> onSome, Action onNone)
            => Model.Match(onSome, onNone);

        public TSome Match<TSome>(Func<TModel, TSome> onSome, Func<TSome> onNone)
            => Model.Match(onSome, onNone); 
#endif
    }
}