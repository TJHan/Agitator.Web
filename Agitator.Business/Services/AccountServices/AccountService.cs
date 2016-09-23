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
using Agitator.Business.Entity.UserEntity;
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
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public LoginUserInfo Login(string userName, string password)
        {
            Dictionary<string, string> dictList = new Dictionary<string, string> { 
                {"userName",userName},
                {"password",password}
            };
            //TODO:
            //这里需要等待接口方修改接口返回数据，然后本地修改LoginUserInfo以映射接口返回值
            LoginUserInfo loginUser = CallAPIHelper.CallAPIInPOST<LoginUserInfo>("/zjyhj/user/auth", dictList);
            if (loginUser != null && loginUser.result == 1 && loginUser.user != null)
            {
                //登录成功，高速缓存用户信息到服务器中
                SessionHelper.SetSession(SessionKeys.LoginUserSessionKey, loginUser);
            }
            return loginUser;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UserLogin(string userName, string password)
        {
            LoginUserInfo loginUser = Login(userName, password);
            if (loginUser != null && loginUser.result == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public bool LogOut()
        {
            return false;
        }
    }
}
