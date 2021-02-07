using System;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Builder
{
    public abstract class
        SteamerRequestBuilder<TRequestBuilder, TRequestInterface> : ISteamerRequestBuilder<TRequestInterface>
        where TRequestBuilder : SteamerRequestBuilder<TRequestBuilder, TRequestInterface>
        where TRequestInterface : ISteamerRequest
    {
        protected SteamerRequestBuilder(ISteamerInterface @interface) =>
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));

        protected ISteamerInterface Interface { get; }
        public TRequestInterface Request { get; protected set; }
        public abstract TRequestInterface Build();

        protected TRequestBuilder SetValue<TValue>(string key, TValue value)
        {
            _ = key ?? throw new ArgumentNullException(nameof(key));
            _ = value ?? throw new ArgumentNullException(nameof(value));

            Request.Method.Parameters.SetValue(key, value);

            return (TRequestBuilder)this;
        }
    }
}