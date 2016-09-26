using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace System.Web.Mvc
{
    /// <summary>
    /// HTML助手类
    /// 此类有问题
    /// </summary>
    public static class CommonHtmlHelper
    {
        //public static string ViewStart(this HtmlHelper html, IDictionary<object, object> pageData)
        //{
        //    return ViewStart(html, pageData, string.Empty);
        //}

        ///// <summary>
        ///// 视图起始
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="pageData">PageData集合</param>
        ///// <param name="layout">布局页</param>
        ///// <returns></returns>
        //public static string ViewStart(this HtmlHelper html, IDictionary<object, object> pageData, string layout)
        //{
        //    string controllerName = html.ViewContext.RouteData.Values["controller"] != null ? html.ViewContext.RouteData.Values["controller"].ToString() : string.Empty;
        //    pageData["controller"] = controllerName;

        //    if (string.IsNullOrEmpty(layout))
        //    {
        //        //areaname需要替换成真实的area名字
        //        return string.Format(@"~/Areas/{0}/Views/Shared/{0}_Layout.cshtml", controllerName, "AreaName");
        //    }
        //    else
        //    {
        //        return string.Format(@"~/Views/Shared/_Layout.cshtml");
        //    }
        //}
    }
}
