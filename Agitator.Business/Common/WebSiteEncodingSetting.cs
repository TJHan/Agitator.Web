using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Common
{
    /// <summary>
    /// 接口编码默认设置
    /// </summary>
    public class WebSiteEncodingSetting
    {
        public static Encoding SiteDefaultEncoding()
        {
            return Encoding.UTF8;
        }
    }
}
