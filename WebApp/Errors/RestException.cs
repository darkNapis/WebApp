using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http.Filters;

namespace WebApp.Errors
{
    public class RestException : Exception
    {
        public RestException(HttpStatusCode code, object errors = null)
        {
            Code = code;
            Errors = errors;
        }
        public HttpStatusCode Code { get; }
        public object Errors { get; }
    }
}
