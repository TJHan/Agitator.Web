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
            if (result != null && result.rows != null)
            {
                result.rows.ToList().ForEach(d =>
                {
                    d.setDate = DateTimeHelper.ConvertIntToDateTimeString(d.setDate);
                    if (!string.IsNullOrEmpty(d.notused))
                    {
                        d.State = d.notused == "0" ? "已停用" : "已启用";
                    }
                });
            }
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
            if (result != null)
                result.setDate = DateTimeHelper.ConvertIntToDateTimeString(result.setDate);
            return result;
        }

        /// <summary>
        /// 创建新企业单位
        /// </summary>
        /// <param name="entity">接口参数实体对象</param>
        /// <returns></returns>
        public ResultAddCompany AddCompany(CompanyAdd entity)
        {
            ResultAddCompany result = CallAPIHelper.CallAPIInPOST<ResultAddCompany>(APIAddressSetting.API_POST_ADDUnit, entity);
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

        /// <summary>
        /// 修改企业单位记录数据
        /// </summary>
        /// <param name="entity">接口参数实体对象</param>
        /// <returns></returns>
        public ResultEntity UpdateCompany(CompanyEdit entity)
        {
            ResultEntity result = CallAPIHelper.CallAPIInPOST<ResultEntity>(APIAddressSetting.API_POST_UPDATEUnit, entity);
            return result;
        }

        /// <summary>
        /// 修改企业单位停用/启用状态
        /// </summary>
        /// <param name="id">企业主键ID</param>
        /// <param name="enable">状态, 0:停用，1：启用</param>
        /// <returns></returns>
        public ResultEntity SetCompanyState(string id, string enable)
        {
            Dictionary<string, string> paramsList = new Dictionary<string, string>() {
                { "id", id },
                { "enable", enable }
            };
            ResultEntity result = CallAPIHelper.CallAPIInPOST<ResultEntity>(APIAddressSetting.API_POST_SETUnitState, paramsList);
            return result;
        }


    }
}
