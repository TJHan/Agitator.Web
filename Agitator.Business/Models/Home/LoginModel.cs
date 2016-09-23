using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Models.Home
{
    /// <summary>
    /// 登录页面模型
    /// </summary>
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// 登录失败信息
        /// </summary>
        public string errorMessage { get; set; }
    }
}
