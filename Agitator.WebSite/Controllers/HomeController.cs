using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Services;
using Agitator.Business.Entity.CommonEntity;
using Agitator.Business.Entity.SystemEntity;

namespace Agitator.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MenuService mService = new MenuService();
            Menu[] menuList = mService.GetUserSystemMenu("admin1");
            Models.SystemModels.MenuModel model = new Models.SystemModels.MenuModel();
            model.MenuList = menuList;
            return View(model);
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