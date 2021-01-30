using System;
using System.Web;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Core.Pipeline.Handlers
{
    public class SteamerRequestToUriPipelineHandler : ISteamerPipelineHandler<ISteamerRequest, (ISteamerRequest, Uri)>
    {
        public (ISteamerRequest, Uri) Process(ISteamerRequest input)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));
            _ = input.Method ?? throw new ArgumentNullException(nameof(input.Method));

            var queryNameValueCollection = HttpUtility.ParseQueryString(string.Empty);

            foreach (var parameter in input.Method.Parameters)
            {
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