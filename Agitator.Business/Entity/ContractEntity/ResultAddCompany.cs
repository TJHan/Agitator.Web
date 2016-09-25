using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 新建企业单位接口返回信息实体类
    /// </summary>
    public class ResultAddCompany
    {
        public string result { get; set; }
        public string errmsg { get; set; }
        public int id { get; set; }
        public string unitId { get; set; }
    }
}
