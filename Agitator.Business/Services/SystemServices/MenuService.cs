using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Entity.SystemEntity;
using Agitator.Business.HttpHandler;
using Agitator.Business.Common;
using Rock.Common.Helper;

namespace Agitator.Business.Services
{
    public class MenuService : BaseService
    {
        /// <summary>
        /// 获取登陆用户的已授权系统板块集合
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Menu[] GetUserSystemMenu(string userName)
        {
            Menu[] result = SessionHelper.GetSession<Menu[]>(SessionKeys.LoginUserMenu);
            if (result == null)
            {
                Dictionary<string, string> dicList = new Dictionary<string, string>(){
                    {"loginName",userName}
                };
                result = CallAPIHelper.CallAPIInPOST<Menu[]>(APIAddressSetting.API_POST_GETSysPowerByLoginName, dicList);
                if (result != null)
                {
                    SessionHelper.SetSession(SessionKeys.LoginUserMenu, result);
                }
            }
            return result;
        }

    }
}
