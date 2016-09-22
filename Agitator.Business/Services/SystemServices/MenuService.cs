using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Entity.SystemEntity;
using Agitator.Business.HttpHandler;

namespace Agitator.Business.Services.SystemServices
{
    public class MenuService:BaseService
    {
        /// <summary>
        /// 获取登陆用户的已授权系统板块集合
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Menu[] GetUserSystemMenu(string userName)
        { 
            Dictionary<string,string> dicList=new Dictionary<string,string>(){
                {"loginName",userName}
            };
            Menu[] result = CallAPIHelper.CallAPIInPOST<Menu[]>("/zjyhj/sysPower/getSysPowerByLoginName", dicList);
            return result;
        }
    }
}
