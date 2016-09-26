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
        #region 操作企业单位API
        /// <summary>
        /// 根据客户单位ID获取单位相信信息接口
        /// </summary>
        public static readonly string API_POST_GETUnit = ConfigurationManager.AppSettings["API_POST_GETUnit"];

        /// <summary>
        /// 获取企业单位集合列表接口
        /// </summary>
        public static readonly string API_POST_GETUnitList = ConfigurationManager.AppSettings["API_POST_GETUnitList"];

        /// <summary>
        /// 新建企业单位接口
        /// </summary>
        public static readonly string API_POST_ADDUnit = ConfigurationManager.AppSettings["API_POST_ADDUnit"];        

        /// <summary>
        /// 根据企业单位ID删除企业单位数据接口
        /// </summary>
        public static readonly string API_POST_DELETEUnit = ConfigurationManager.AppSettings["API_POST_DELETEUnit"];

        /// <summary>
        /// 根据企业单位ID删除企业单位数据接口
        /// </summary>
        public static readonly string API_POST_UPDATEUnit = ConfigurationManager.AppSettings["API_POST_UPDATEUnit"];

        /// <summary>
        /// 停用/启用企业单位API
        /// </summary>
        public static readonly string API_POST_SETUnitState = ConfigurationManager.AppSettings["API_POST_SETUnitState"];

        /// <summary>
        /// 获取已分配到单位的站点集合接口
        /// </summary>
        public static readonly string API_POST_GETUnitSyncList = ConfigurationManager.AppSettings["API_POST_GETUnitSyncList"];
        
        /// <summary>
        /// 新增单位到指定站点的同步配置接口
        /// </summary>
        public static readonly string API_POST_ADDUnitSync = ConfigurationManager.AppSettings["API_POST_ADDUnitSync"];

        /// <summary>
        /// 删除单位到某个站点的同步配置接口
        /// </summary>
        public static readonly string API_POST_DELETEUnitSync = ConfigurationManager.AppSettings["API_POST_DELETEUnitSync"];

        /// <summary>
        /// 设置单位到某个站点的同步配置的开关接口
        /// </summary>
        public static readonly string API_POST_SETUnitSyncState = ConfigurationManager.AppSettings["API_POST_SETUnitSyncState"];

        #endregion

        #region 公共操作API
        /// <summary>
        /// 获取企业单位类型接口
        /// </summary>
        public static readonly string API_GET_CompanyType = ConfigurationManager.AppSettings["API_GET_CompanyType"];

        /// <summary>
        /// 获取企业单位等级接口
        /// </summary>
        public static readonly string API_GET_CompanyGrade = ConfigurationManager.AppSettings["API_GET_CompanyGrade"];
        #endregion

        #region 登录用户及权限API
        /// <summary>
        /// 用户登录接口
        /// </summary>
        public static readonly string API_POST_Login = ConfigurationManager.AppSettings["API_POST_Login"];

        /// <summary>
        /// 获取用户权限接口
        /// </summary>
        public static readonly string API_POST_GETSysPowerByLoginName = ConfigurationManager.AppSettings["API_POST_GETSysPowerByLoginName"];
        #endregion

        #region 操作站点API
        /// <summary>
        /// 获取站点集合数据接口
        /// </summary>
        public static readonly string API_POST_GETSiteList = ConfigurationManager.AppSettings["API_POST_GETSiteList"];
        #endregion

    }
}
