using System;
using System.Web;
using Sirh3e.Steamer.Core.Pipeline;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Pipelines.Handlers
{
    public class
        SteamerWebServiceRequestToUriPipelineHandler<TSteamerRequest> :
            ISteamerPipelineHandler<TSteamerRequest, (TSteamerRequest, Uri)>
        where TSteamerRequest : ISteamerRequest
    {
        public (TSteamerRequest, Uri) Process(TSteamerRequest input)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));
            _ = input.Method ?? throw new ArgumentNullException(nameof(input.Method));

            var queryNameValueCollection = HttpUtility.ParseQueryString(string.Empty);

            foreach (var parameter in input.Method.Parameters)
            {
                if (parameter.Required.Equals(false) &&
                    string.IsNullOrWhiteSpace(parameter.GetValueFromQueryString())) continue;

                queryNameValueCollection.Set(parameter.Name, parameter.GetValueFromQueryString());
            }

            var builder = new UriBuilder(input.Method.GetUriHost())
            {
                Query = queryNameValueCollection.ToString() ?? string.Empty
            };

            var uri = new Uri(builder.ToString());

            return (input, uri);
        }
    }
}