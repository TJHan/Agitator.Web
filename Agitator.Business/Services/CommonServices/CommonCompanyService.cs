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
    public class CommonCompanyService : BaseService
    {
        /// <summary>
        /// 获取企业单位类型集合
        /// </summary>
        /// <returns></returns>
        public CompanyTypeItem[] APIGetCompanyTypeList()
        {
            var result = CallAPIHelper.CallAPIInGET<CompanyTypeItem[]>("/zjyhj/pact/unit/getTypeList");
            return result;            
        }

        /// <summary>
        /// 获取企业等级类型集合
        /// </summary>
        /// <returns></returns>
        public CompanyGradeItem[] APIGetCompanyGradeList()
        {
            var result = CallAPIHelper.CallAPIInGET<CompanyGradeItem[]>("/zjyhj/pact/unit/getTypeList");
            return result;
        }
    }
}
