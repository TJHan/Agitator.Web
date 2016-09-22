using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Common;
using Rock.Common.Helper;

namespace Agitator.Business.Common
{
    public class RequestUser
    {
        public bool Login()
        {
            return true;
        }

        /// <summary>
        /// 是否是登录状态
        /// </summary>
        public bool IsLogin
        {
            get
            {
                object loginUser = SessionHelper.GetSession<object>(SessionKeys.LoginUserSessionKey);
                if (loginUser != null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
