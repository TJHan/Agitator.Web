using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agitator.WebSite.Filters
{
    public class AuthAttribute:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext);
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {            
            //跳转到登录页面
            HttpContext.Current.Response.Redirect("");
            HttpContext.Current.Response.SuppressContent = false;
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}