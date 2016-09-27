using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Filters;
using Agitator.Business.Services.ContractServices;
using Agitator.Business.Services.StationServices;
using Agitator.Business.ParameterEntity;
using Rock.Common.Helper;
using Agitator.Business.Entity.ContractEntity;
using Agitator.Business.Entity.CommonEntity;
using Agitator.Business.Entity.StationEntity;
using Agitator.Business.Services;
using Agitator.Business.Helper;
using Agitator.Business.Common;
using Agitator.Business.Models.Contract;

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
                //修改
                var result = _cServices.GetCompanyDetails(id);
                if (result != null)
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
            else
            {
                //新建
                model.setDate = DateTime.Now.ToString();
                //登记人字段暂用登录用户的登录名
                model.setMan = RequestUser.CurrentRequestUser.CurrentLoginUserInfo.user.loginName;
            }

            LoadDropDownListData();
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CompanyEdit model)
        {
            //日期格式转换成Unix时间戳格式。
            if (!string.IsNullOrEmpty(model.setDate))
                model.setDate = DateTimeHelper.ConvertDateTimeInt(model.setDate.ToDateTime()).ToString();
            if (model.id > 0)
            {
                //修改                
                Entity.ResultEntity updateResult = _cServices.UpdateCompany(model);
                ShowMessageHelper.MessageBoxBackPage("单位信息修改成功");
            }
            else
            {
                //新建
                CompanyAdd entity = new CompanyAdd()
                {
                    unitName = model.unitName,
                    address = model.address,
                    clientId = model.clientId,
                    cop = model.cop,
                    fax = model.fax,
                    tel1 = model.tel1,
                    tel2 = model.tel2,
                    typeId = model.typeId,
                    gradeSid = model.gradeSid,
                    linkman = model.linkman,
                    notused = model.notused,
                    remark = model.remark,
                    setDate = model.setDate,
                    setMan = model.setMan
                };

                ResultAddCompany addResult = _cServices.AddCompany(entity);
                if (addResult != null && addResult.result == "1")
                {
                    model.id = addResult.id;
                    model.unitId = addResult.unitId;
                    ShowMessageHelper.MessageBoxBackPage("单位信息创建成功");
                }
                else
                {
                    ShowMessageHelper.MessageBoxBackPage("服务器异常，请稍后再试");
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

        /// <summary>
        /// 维护单位同步站点数据Action
        /// </summary>
        /// <returns></returns>
        public ActionResult SyncUnitMain()
        {
            return View();
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

        /// <summary>
        /// 根据条件获取可配置的站点数据集合
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult LoadStationList(ParamsStationSearch search)
        {
            StationServices sService = new StationServices();
            var result = sService.GetStationList(search);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取已设置的单位同步站点数据集合
        /// </summary>
        /// <param name="id">单位主键ID</param>
        /// <returns></returns>
        public ActionResult LoadSyncStationList(string id)
        {
            ParamsSyncStationSearch search = new ParamsSyncStationSearch
            {
                unitId = id.ToInt()
            };
            var result = _cServices.GetSyncStationList(search);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
