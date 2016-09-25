using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

using Agitator.Business.Entity.CommonEntity;
using Agitator.Business.Common;
using Agitator.Business.HttpHandler;
using Rock.Logging;
using Rock.Common.Serialize;


namespace Agitator.Business.Services
{
    /// <summary>
    /// 企业单位管理模块通用接口服务类
    /// </summary>
    public class CommonCompanyService : BaseService
    {
        /// <summary>
        /// 获取企业单位类型集合
        /// </summary>
        /// <returns></returns>
        public CompanyTypeItem[] GetCompanyTypeList()
        {
            var result = CallAPIHelper.CallAPIInGET<CompanyTypeItem[]>(APIAddressSetting.API_GET_CompanyType);
            return result;            
        }

        /// <summary>
        /// 获取企业等级类型集合
        /// </summary>
        /// <returns></returns>
        public CompanyGradeItem[] GetCompanyGradeList()
        {
            var result = CallAPIHelper.CallAPIInGET<CompanyGradeItem[]>(APIAddressSetting.API_GET_CompanyGrade);
            return result;
        }
    }
}
