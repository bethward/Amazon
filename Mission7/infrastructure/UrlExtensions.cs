using System;
using Microsoft.AspNetCore.Http;

namespace Mission7.infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) => request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.PathAndQuery().ToString();
        
    }
}
