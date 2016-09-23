using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agitator.Business.Services;
using Agitator.Business.Entity.CommonEntity;
using Agitator.Business.Entity.SystemEntity;
using Agitator.Business.Models.Home;
using Agitator.Business.Filters;
using Agitator.Business.Common;

namespace Agitator.WebSite.Controllers
{
    public class HomeController : Controller
    {
        [Auth("")]
        public ActionResult Index()
        {
            MenuService mService = new MenuService();
            Menu[] menuList = mService.GetUserSystemMenu("admin1");
            Models.SystemModels.MainPageModel model = new Models.SystemModels.MainPageModel();
            model.MenuList = menuList;
            return View(model);
        }

        public ActionResult Login()
        {
            if (RequestUser.CurrentRequestUser.IsLogin)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            AccountService aService = new AccountService();
            bool result = aService.UserLogin(model.UserName, model.Password);
            if (result)
            {
                return RedirectToAction("Index");
            }
            model.errorMessage = "用户名或密码错误";
            return View(model);
        }
    }
}