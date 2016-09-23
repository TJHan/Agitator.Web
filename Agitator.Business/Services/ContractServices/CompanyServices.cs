using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Entity.ContractEntity;
using Agitator.Business.ParameterEntity;
using Agitator.Business.HttpHandler;

namespace Agitator.Business.Services.ContractServices
{
    /// <summary>
    /// 企业单位
    /// </summary>
    public class CompanyServices : BaseService
    {
        /// <summary>
        /// 查询企业单位数据集合
        /// </summary>
        /// <param name="searchEntity">企业单位查询条件对象</param>
        /// <returns></returns>
        public CompanyList GetCompanyList(ParamsCompanySearch searchEntity)
        {
            Dictionary<string, string> paramsList = new Dictionary<string, string>()
            {
                { "page", searchEntity.PageIndex.ToString() },
                { "rows", searchEntity.PageSize.ToString() },
                { "unitId", searchEntity.UnitId },
                { "unitName", searchEntity.UnitName },
                { "linkman", searchEntity.linkman }
            };
            CompanyList result = CallAPIHelper.CallAPIInPOST<CompanyList>("/zjyhj/pact/unit/getUnitList", paramsList);
            return result;
        }
    }
}
