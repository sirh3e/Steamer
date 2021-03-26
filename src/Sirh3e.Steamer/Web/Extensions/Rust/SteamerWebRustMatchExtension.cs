using System;
using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Extensions.Model;
using Sirh3e.Steamer.Web.Models;

namespace Sirh3e.Steamer.Web.Extensions.Rust
{
    public static class SteamerWebRustMatchExtension
    {
        public static void Match<TResponse>(this Option<SteamerWebResponseModel<TResponse>> option,
            Action<TResponse> onOk,
            Action onErr) =>
            option.Match(response =>
            {
                _ = onOk ?? throw new ArgumentNullException(nameof(onOk));
                _ = response ?? throw new ArgumentNullException(nameof(response));

                var model = response.GetModel();
                onOk(model ?? throw new ArgumentNullException(nameof(model)));
            }, () => { _ = onErr ?? throw new ArgumentNullException(nameof(onErr)); });

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