using System;
using Sirh3e.Steamer.Core.Response;

namespace Sirh3e.Steamer.Core.Extensions.Response
{
    public static class SteamerResponseExtension
    {
#if !NETSTANDARD2_1_OR_GREATER
        public static void Match<TModel>(this ISteamerResponse<TModel> response, Action<TModel> onSome, Action onNone)
            => response.Model.Match(onSome, onNone);
        
        public static TSome Match<TModel, TSome>(this ISteamerResponse<TModel> response, Func<TModel, TSome> onSome, Func<TSome> onNone)
            => response.Model.Match(onSome, onNone);
#endif
    }
}