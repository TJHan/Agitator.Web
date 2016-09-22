using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Agitator.Business.Services
{
    /// <summary>
    /// 接口调用服务基类
    /// </summary>
    public abstract class BaseService
    {
        /// <summary>
        /// 已无效
        /// </summary>
        [Obsolete("此属性已无效，请使用HttpHandler.CallAPIHelper助手类调用API")]
        protected readonly string BaseAPIAddress = ConfigurationManager.AppSettings["zjyhj.services"];
    }
}
