using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Common;
using Agitator.Business.Entity.SystemEntity;
using Rock.Common.Helper;

namespace Agitator.Business.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthAttribute : AuthorizeAttribute
    {
        public AuthAttribute(string rightsKey)
        {
            this.webSiteRightsKey = rightsKey;
        }
        private string webSiteRightsKey = string.Empty;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //校验登录，还需验证板块授权
            if (!RequestUser.CurrentRequestUser.IsLogin)
                return false;

            return CheckAuthorizedModules(httpContext);
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //未授权错误时跳转至主页
            if (filterContext.HttpContext.Response.StatusCode == 401)
            {
                HttpContext.Current.Response.Redirect(RequestUser.CurrentRequestUser.DefaultURL);
            }
            else
            {
                //跳转到登录页面
                HttpContext.Current.Response.Redirect(RequestUser.CurrentRequestUser.LoginURL);
                HttpContext.Current.Response.SuppressContent = false;
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
        }

        /// <summary>
        /// 校验登录用户此板块是否已授权
        /// </summary>
        /// <returns></returns>
        private bool CheckAuthorizedModules(HttpContextBase httpContext)
        {
            //主页权限键为空，无需授权
            if (string.IsNullOrEmpty(webSiteRightsKey))
                return true;

            Menu[] menuList = RequestUser.CurrentRequestUser.LoginUserMenuList;

            if (menuList == null)
            {
                httpContext.Response.StatusCode = 401;
                return false;
            }

            var list = ModuleMapping.ModuleMappingDict.Where(d => d.Value.RightsKey.Equals(webSiteRightsKey));
            if (list == null)
            {
                httpContext.Response.StatusCode = 401;
                return false;
            }
            var item = menuList.Where(d => d.id == list.FirstOrDefault().Key.ToInt()).FirstOrDefault();
            if (item == null)
            {
                httpContext.Response.StatusCode = 401;
                return false;
            }
            return true;
        }
    }
}
