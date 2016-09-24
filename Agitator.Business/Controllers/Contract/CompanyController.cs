using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Filters;
using Agitator.Business.Services.ContractServices;
using Agitator.Business.ParameterEntity;
using Rock.Common.Helper;

namespace Agitator.Business.Controllers.Contract
{
    /// <summary>
    /// 合同管理模块->单位管理板块控制器
    /// </summary>
    [Auth("AgitatorSite_Contract_OrderContract")]
    public class CompanyController : AgitatorControllerBase
    {
        private CompanyServices _cServices;
        public CompanyController()
        {
            _cServices = new CompanyServices();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadCompanyList(ParamsCompanySearch queryData)
        {
            queryData.PageIndex = 0;
            queryData.PageSize = 0;
            var result = _cServices.GetCompanyList(queryData);            
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 单位详情页面Action
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var result = _cServices.GetCompanyDetails(id);
            return View(result);
        }

        /// <summary>
        /// 删除单位记录Action
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(string id)
        {
            var result = _cServices.DeleteCompany(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
