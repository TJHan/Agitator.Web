using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity
{
    /// <summary>
    /// 接口调用返回结果类
    /// </summary>
    public class ResultEntity
    {
        /// <summary>
        /// 返回结果， 0：失败, 1：成功
        /// </summary>
        public string result { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string errmsg { get; set; }
    }
}
