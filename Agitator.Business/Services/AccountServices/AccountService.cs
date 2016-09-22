using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using Rock.Common;
using System.Configuration;
using Agitator.Business.Entity.CommonEntity;
using Agitator.Business.HttpHandler;
using Agitator.Business.Common;
using Rock.Common.Helper;

namespace Agitator.Business.Services
{
    /// <summary>
    /// 用户功能类
    /// </summary>
    public class AccountService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool APILogin(string userName, string password)
        {
            Dictionary<string, string> dictList = new Dictionary<string, string> { 
                {"userName",userName},
                {"password",password}
            };
            var result = CallAPIHelper.CallAPIInPOST<string>("/zjyhj/user/auth", dictList);

            //TODO:
            //登录成功，高速缓存用户信息到服务器中
            SessionHelper.SetSession(SessionKeys.LoginUserSessionKey, result);
            return true;
        }


    }
}
