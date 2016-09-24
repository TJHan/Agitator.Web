using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Entity.ContractEntity;
using Agitator.Business.ParameterEntity;
using Agitator.Business.HttpHandler;
using Agitator.Business.Helper;
using Agitator.Business.Common;
using Agitator.Business.Entity;

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
            CompanyList result = CallAPIHelper.CallAPIInPOST<CompanyList>(APIAddressSetting.API_POST_GETUnitList, paramsList);
            result.rows.ToList().ForEach(d =>
            {
                d.setDate = DateTimeHelper.ConvertIntDateTime(d.setDate).HasValue ? DateTimeHelper.ConvertIntDateTime(d.setDate).Value.ToString("yyyy-MM-dd") : string.Empty;
            });
            return result;
        }

        /// <summary>
        /// 获取企业单位详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CompanyDetails GetCompanyDetails(string id)
        {
            Dictionary<string, string> paramsList = new Dictionary<string, string>() {
                { "id", id }
            };
            CompanyDetails result = CallAPIHelper.CallAPIInPOST<CompanyDetails>(APIAddressSetting.API_POST_GETUnit, paramsList);
            return result;
        }

        /// <summary>
        /// 删除企业单位记录
        /// </summary>
        /// <param name="id">企业单位主键ID</param>
        /// <returns></returns>
        public ResultEntity DeleteCompany(string id)
        {
            Dictionary<string, string> paramsList = new Dictionary<string, string>() {
                { "id", id }
            };
            ResultEntity entity = CallAPIHelper.CallAPIInPOST<ResultEntity>(APIAddressSetting.API_POST_DELETEUnit, paramsList);
            return entity;
        }

    }
}
