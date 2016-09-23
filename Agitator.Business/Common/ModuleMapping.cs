using Rock.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Common
{
    /// <summary>
    /// 功能板块与站点页面映射类
    /// </summary>
    public class ModuleMapping
    {
        /// <summary>
        /// 映射字典
        /// key为板块主键ID，value为此板块映射的路由信息对象
        /// </summary>
        public static Dictionary<string, ModuleRoute> ModuleMappingDict
        {
            get
            {
                Dictionary<string, ModuleRoute> moduleMappingDict = CacheHelper.GetCache<Dictionary<string, ModuleRoute>>(CacheKeys.GlobalAgitatorModuleCache);
                if (moduleMappingDict == null)
                {
                    //功能板块-站点页面映射关系存入服务器高速缓存中
                    moduleMappingDict = new Dictionary<string, ModuleRoute>() { 
                        { "1", new ModuleRoute{ Action = "", Controller = "", Area = "Contract", ModuleName = "合同管理",RightsKey = "" }},
                        { "2", new ModuleRoute{ Action = "Index", Controller = "Company", Area = "Contract", ModuleName = "单位管理", RightsKey = "AgitatorSite_Contract_Company" }},
                        { "3", new ModuleRoute{ Action = "Index", Controller = "Engineering", Area = "Contract", ModuleName = "工程管理", RightsKey = "AgitatorSite_Contract_Engineering" }},
                        { "4", new ModuleRoute{ Action = "Index", Controller = "OrderContract", Area = "Contract", ModuleName = "合同管理", RightsKey = "AgitatorSite_Contract_OrderContract" }},
                    };
                    CacheHelper.SetCache(CacheKeys.GlobalAgitatorModuleCache, moduleMappingDict);
                }
                return moduleMappingDict;
            }
        }
    }

    /// <summary>
    /// 板块路由信息类
    /// </summary>
    public class ModuleRoute
    {
        /// <summary>
        /// 响应Action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 控制器
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// 所属区域
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 板块名称
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// 权限键
        /// </summary>
        public string RightsKey { get; set; }
    }
}
