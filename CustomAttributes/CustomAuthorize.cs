using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace SampleProject.WebApi.CustomAttributes
{
    public class CustomAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //Handle request url
            string requestUrl = actionContext.Request.RequestUri.AbsoluteUri;
            
            //Other processes, log etc.

            base.OnAuthorization(actionContext);
        }
    }
}