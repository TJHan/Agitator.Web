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
using Agitator.Business.Entity.ContractEntity;
using Agitator.Business.Services;
using Agitator.Business.Entity.CommonEntity;

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
            if (result == null)
                result = new CompanyDetails();
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

        /// <summary>
        /// 修改/新建企业单位数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(string id)
        {
            CompanyEdit model = new CompanyEdit();
            if (!string.IsNullOrEmpty(id))
            {
                var result = _cServices.GetCompanyDetails(id);
                if (result == null)
                {
                    model.id = result.id;
                    model.unitId = result.unitId;
                    model.unitName = result.unitName;
                    model.address = result.address;
                    model.clientId = result.clientId;
                    model.cop = result.cop;
                    model.fax = result.fax;
                    model.tel1 = result.tel1;
                    model.tel2 = result.tel2;
                    model.typeId = result.typeId;
                    model.gradeSid = result.gradeSid;
                    model.linkman = result.linkman;
                    model.notused = result.notused;
                    model.remark = result.remark;
                    model.setDate = result.setDate;
                    model.setMan = result.setMan;
                }
            }
            LoadDropDownListData();
            return View(model);
        }

        /// <summary>
        /// 修改企业单位状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult UpdateCompanyState(string id, string state)
        {
            var result = _cServices.SetCompanyState(id, state);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private void LoadDropDownListData()
        {
            CommonCompanyService commons = new CommonCompanyService();
            CompanyTypeItem[] typeList = commons.GetCompanyTypeList();
            CompanyGradeItem[] gradeList = commons.GetCompanyGradeList();
            List<SelectListItem> typeSelect = new List<SelectListItem>();
            List<SelectListItem> gradeSelect = new List<SelectListItem>();
            foreach (var item in typeList)
            {
                typeSelect.Add(new SelectListItem { Text = item.caption, Value = item.id.ToString() });
            }
            foreach (var item in gradeList)
            {
                gradeSelect.Add(new SelectListItem { Text = item.caption, Value = item.id.ToString() });
            }
            ViewData["CompanyTypeList"] = typeSelect;
            ViewData["CompanyGradeList"] = gradeSelect;
        }
    }
}
