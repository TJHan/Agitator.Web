using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Agitator.Business.Common;
using Agitator.Business.Entity.SystemEntity;
using Agitator.Business.Entity.UserEntity;
using Agitator.Business.Services;
using Rock.Common.Helper;


namespace Agitator.Business.Common
{
    /// <summary>
    /// 当前请求用户信息
    /// </summary>
    public class RequestUser
    {
        private RequestUser()
        { }

        public static RequestUser CurrentRequestUser
        {
            get
            {
                RequestUser user = new RequestUser();
                return user;
            }
        }
        /// <summary>
        /// 是否是登录状态
        /// </summary>
        public bool IsLogin
        {
            get
            {
                if (CurrentLoginUserInfo != null)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 当前登录用户的信息
        /// </summary>
        public LoginUserInfo CurrentLoginUserInfo
        {
            get
            {
                LoginUserInfo loginUser = SessionHelper.GetSession<LoginUserInfo>(SessionKeys.LoginUserSessionKey);
                return loginUser;
            }
        }

        /// <summary>
        /// 当前登录用户的已授权板块数组
        /// </summary>
        public Menu[] LoginUserMenuList
        {
            get
            {
                MenuService mService = new MenuService();
                //RequestUser需要提供一个userInfo类型的属性，保存已登录的账户的信息，此处参数将使用此属性的username
                return mService.GetUserSystemMenu("admin1");
            }
        }

        public string LoginURL
        {
            get
            {
#if DEBUG
                return string.Format(@"http://{0}:{1}/Home/Login", HttpContext.Current.Request.Url.Host, HttpContext.Current.Request.Url.Port);
#else
                return string.Format(@"http://{0}/Home/Login", HttpContext.Current.Request.Url.Host);
#endif

            }
        }
        public string DefaultURL
        {
            get {
#if DEBUG
                return string.Format(@"http://{0}:{1}", HttpContext.Current.Request.Url.Host, HttpContext.Current.Request.Url.Port);
#else
                return string.Format(@"http://{0}", HttpContext.Current.Request.Url.Host);
#endif
            }
        }
    }
}
