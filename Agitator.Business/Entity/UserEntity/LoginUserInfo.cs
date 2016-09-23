using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.UserEntity
{
    /// <summary>
    /// 登录用户实体类
    /// </summary>
    [Serializable]
    public class LoginUserInfo
    {
        /// <summary>
        /// 接口调用结果
        /// </summary>
        public int result { get; set; }

        /// <summary>
        /// 登录账户信息
        /// </summary>
        public User user { get; set; }
    }

    [Serializable]
    public class User
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string loginName { get; set; }
        public int personnelId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string name { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }

        /// <summary>
        /// 所属科室
        /// </summary>
        public string departmentName { get; set; }

        /// <summary>
        /// 用户姓名？
        /// </summary>
        public string uname { get; set; }
    }
}
