using System;
using System.Threading.Tasks;
using System.Web;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Web.Errors;
using Sirh3e.Steamer.Web.Internal.Rust;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class
        SteamerWebServiceRequestToUriPipelineHandler<TSteamerRequest> : ISteamerPipelineHandler<TSteamerRequest,
            Task<Result<(TSteamerRequest, Uri), ISteamerWebError>>>
        where TSteamerRequest : ISteamerRequest
    {
        public SteamerWebServiceRequestToUriPipelineHandler(ISteamerAuthProvider steamerAuthProvider)
        {
            AuthProvider = steamerAuthProvider;
        }

        public ISteamerAuthProvider AuthProvider { get; set; }


        public async Task<Result<(TSteamerRequest, Uri), ISteamerWebError>> Process(TSteamerRequest input)
        {
            static Result<(TSteamerRequest, Uri), ISteamerWebError> OnOk(TSteamerRequest request, Uri uri)
                => (request, uri).FromOk();

            var queryNameValueCollection = HttpUtility.ParseQueryString(string.Empty);

            var key = "key";
            if ( input.Method.Parameters.TryGetValue(key, out SteamerStringParameter keyParameter) )
            {
                if ( keyParameter.Required && string.IsNullOrEmpty(keyParameter.GetValueFromQueryString()) )
                {
                    input.Method.Parameters.SetValue(key, AuthProvider.ApiKey);
                }
            }

            foreach ( var parameter in input.Method.Parameters )
            {
                if ( parameter.Required.Equals(false) &&
                     string.IsNullOrWhiteSpace(parameter.GetValueFromQueryString()) )
                    continue;

                queryNameValueCollection.Set(parameter.Name, parameter.GetValueFromQueryString());
            }

            var builder = new UriBuilder(input.Method.GetUriHost())
            {
                Query = queryNameValueCollection.ToString() ?? string.Empty
            };

            var uri = new Uri(builder.ToString());

            return OnOk(input, uri);
        }
    }
}