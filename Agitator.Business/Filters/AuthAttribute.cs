using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using Agitator.Business.Common;
using Rock.Common.Helper;

namespace Agitator.Business.Filters
{
    public class AuthAttribute:AuthorizeAttribute
    {
        public AuthAttribute(string moduleKey)
        {
            this.webSiteModuleRightsKey = moduleKey;
        }

        private string webSiteModuleRightsKey = string.Empty;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!RequestUser.CurrentRequestUser.IsLogin)
                return false;

            return CheckAuthorizedModules();
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            HttpContext.Current.Response.Redirect(RequestUser.CurrentRequestUser.LoginURL);
            HttpContext.Current.Response.SuppressContent = false;
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        private bool CheckAuthorizedModules()
        {
            var module = ModuleMapping.ModuleMappingDict.Where(d => d.Value.RightsKey.Equals(webSiteModuleRightsKey)).FirstOrDefault();
            var result = RequestUser.CurrentRequestUser.LoginUserMenuList.Where(d => d.id == module.Key.ToInt());
            if (result != null && result.FirstOrDefault() != null)
            {

                return true;
            }
            return false;
        }
    }
}
