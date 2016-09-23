using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Filters;

namespace Agitator.Business.Controllers.Contract
{
    /// <summary>
    /// 合同管理模块->单位管理板块控制器
    /// </summary>
    [Auth("AgitatorSite_Contract_OrderContract")]
    public class CompanyController : AgitatorControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
