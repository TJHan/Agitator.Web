using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Agitator.Business.Helper
{
    public class ShowMessageHelper
    {
        /// <summary>
        /// 弹出页面消息框
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowMessageBox(string msg)
        {
            msg = HttpUtility.HtmlDecode(msg);
            HttpContext.Current.Response.Write("");
        }

        public static string MessageBoxBackPage(string mess)
        {
            return MessageBox(mess, string.Empty, "history.go(-1);");
        }

        public static string MessageBox(string msg, string surl, string other = "")
        {
            string mask = "<script language=\"JavaScript\" type=\"text/JavaScript\">var lurl = '{loca}';if('{message}'!='')jQuery.messager.alert('{message}');if(lurl.length > 1){ window.location = lurl;} {othop} </script>";

            StringBuilder sb = new StringBuilder(mask);

            if (msg != null)
                sb.Replace("{message}", msg.Replace("'", @"\'").Replace("\r", "").Replace("\n", ""));

            sb.Replace("{loca}", surl);
            sb.Replace("{othop}", other);

            // throw new Exception(sout);

            return sb.ToString();
        }
    }
}
