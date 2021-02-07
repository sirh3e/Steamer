using System;
using Sirh3e.Steamer.Web.Models;

namespace Sirh3e.Steamer.Web.Extensions.Model
{
    public static class SteamerWebResponseExtension
    {
        public static TModel GetModel<TModel>(this SteamerWebResponseModel<TModel> response)
        {
            _ = response ?? throw new ArgumentNullException(nameof(response));
            
            return response.Response;
        }
    }
}