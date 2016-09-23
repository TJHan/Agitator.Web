using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Common
{
    /// <summary>
    /// 缓存键常量类
    /// </summary>
    public class SessionKeys
    {
        /// <summary>
        /// 登录用户信息缓存键
        /// </summary>
        public const string LoginUserSessionKey = "AGITATOR_LOGIN_USER_INFO";

        /// <summary>
        /// 登录用户的已授权功能模块
        /// </summary>
        public const string LoginUserMenu = "AGITATOR_LOGIN_USER_MENU";
    }
}
