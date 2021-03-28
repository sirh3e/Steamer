using System;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Extensions.Model;
using Sirh3e.Steamer.Web.Models;

namespace Sirh3e.Steamer.Web.Extensions.Rust
{
    public static class SteamerWebRustMatchExtension
    {
        public static void Match<TResponse>(this ISteamerResponse<SteamerWebResponseModel<TResponse>> response,
            Action<TResponse> onSome,
            Action onNone)
            => response.Model.Match(onSome, onNone);

        public static TModel Match<TResponse, TModel>(this ISteamerResponse<SteamerWebResponseModel<TResponse>> response,
            Func<TResponse, TModel> onSome,
            Func<TModel> onNone)
            => response.Model.Match(onSome, onNone);

        public static void Match<TResponse>(this Option<SteamerWebResponseModel<TResponse>> option,
            Action<TResponse> onSome,
            Action onNone) =>
            option.Match(response =>
            {
                _ = onSome ?? throw new ArgumentNullException(nameof(onSome));
                _ = response ?? throw new ArgumentNullException(nameof(response));

                var model = response.GetModel();
                onSome(model ?? throw new ArgumentNullException(nameof(model)));
            }, () => { _ = onNone ?? throw new ArgumentNullException(nameof(onNone)); });

        public static TModel Match<TResponse, TModel>(this Option<SteamerWebResponseModel<TResponse>> option,
            Func<TResponse, TModel> onSome,
            Func<TModel> onNone) =>
            option.Match(response =>
            {
                _ = response ?? throw new ArgumentNullException(nameof(response));
                _ = onSome ?? throw new ArgumentNullException(nameof(onSome));

                var model = response.GetModel();
                return onSome(model ?? throw new ArgumentNullException(nameof(model)));
            }, () =>
            {
                _ = onNone ?? throw new ArgumentNullException(nameof(onNone));

                return onNone();
            });
    }
}