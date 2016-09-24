using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 企业单位详情类
    /// </summary>
    public class CompanyDetails
    {
        public int id { get; set; }
        public string address { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string linkman { get; set; }
        public string fax { get; set; }
        public string remark { get; set; }
        public string typeId { get; set; }
        public string cop { get; set; }
        public string clientId { get; set; }
        public string setMan { get; set; }
        public string setDate { get; set; }
        public string gradeSid { get; set; }
        public string notused { get; set; }
        public string createUserId { get; set; }
        public string uid { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string uname { get; set; }
    }
}
