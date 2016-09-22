using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agitator.WebSite.Extensions
{
    public class WebSiteContext
    {
        private WebSiteContext()
        { }

        /// <summary>
        /// 当前上下文实例
        /// </summary>
        public static WebSiteContext Current
        {
            get
            {
                WebSiteContext context = new WebSiteContext();
                return context;
            }
        }

        public bool IsLogin
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 登录地址
        /// </summary>
        public string LoginAddress
        {
            get
            {
                return "";
            }
        }
    }
}