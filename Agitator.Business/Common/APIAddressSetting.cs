using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Agitator.Business.Common
{
    public class APIAddressSetting
    {
        /// <summary>
        /// 根据客户单位ID获取单位相信信息接口
        /// </summary>
        public static readonly string API_POST_GETUnit = ConfigurationManager.AppSettings["API_POST_GETUnit"];

        /// <summary>
        /// 获取企业单位集合列表接口
        /// </summary>
        public static readonly string API_POST_GETUnitList = ConfigurationManager.AppSettings["API_POST_GETUnitList"];

        /// <summary>
        /// 根据企业单位ID删除企业单位数据接口
        /// </summary>
        public static readonly string API_POST_DELETEUnit = ConfigurationManager.AppSettings["API_POST_DELETEUnit"];
    }
}
