using System.Web;
using System.Web.Optimization;

namespace Agitator.WebSite
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //EasyUI
            bundles.Add(new ScriptBundle("~/bundles/easyui").Include(
                "~/Scripts/jquery.easyui-*"));

            bundles.Add(new ScriptBundle("~/bundles/easyui/custom").Include(
                "~/Scripts/easyUI/EasyUI.js"));

            bundles.Add(new ScriptBundle("~/bundles/easyui/customMain").Include(
                "~/Scripts/easyUI/EasyUI.Custom.Main.js"));

            //数据列表JS
            bundles.Add(new ScriptBundle("~/bundles/easyui/datagrid").Include("~/Scripts/easyUI/datagrid-scrollview.js"));

            //EasyUI灰色风格样式
            bundles.Add(new StyleBundle("~/Content/themes/gray/css").IncludeDirectory("~/Content/themes/gray", "*.css"));

            bundles.Add(new StyleBundle("~/Content/themes/metro/css").IncludeDirectory("~/Content/themes/metro", "*.css"));

            bundles.Add(new StyleBundle("~/Content/themes/bootstrap/css").IncludeDirectory("~/Content/themes/bootstrap", "*.css"));

            bundles.Add(new StyleBundle("~/Content/themes/easyui/custom").Include("~/Content/themes/easyUI_CustomMain.css"));


        }
    }
}
