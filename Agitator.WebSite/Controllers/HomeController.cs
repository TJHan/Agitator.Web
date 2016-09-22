using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Services;
using Agitator.Business.Entity.CommonEntity;

namespace Agitator.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CommonCompanyService service = new CommonCompanyService();
            var result = service.APIGetCompanyTypeList();
            AccountService aservice = new AccountService();
            aservice.APILogin("admin", "admin");
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}