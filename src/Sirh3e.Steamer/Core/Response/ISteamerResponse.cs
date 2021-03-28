using System;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Response
{
    public interface ISteamerResponse<TRequest, TModel>
        where TRequest : ISteamerRequest
    {
        public TRequest Request { get; init; } //Change Request Type
        public Option<TModel> Model { get; init; }

        public void Match(Action<TModel> onSome, Action onNone)
            => Model.Match(onSome, onNone);

        public TSome Match<TSome>(Func<TModel, TSome> onSome, Func<TSome> onNone)
            => Model.Match(onSome, onNone);
    }
}