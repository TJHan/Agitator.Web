using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 企业单位列表类
    /// </summary>
    public class CompanyList
    {
        public int total { get; set; }
        public CompanyItem[] rows { get; set; }
    }

    /// <summary>
    /// 企业单位列表页面的企业单位类
    /// </summary>
    public class CompanyItem
    {
        /// <summary>
        /// 单位主键ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitId { get; set; }
        public string address { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string linkman { get; set; }
        public string fax { get; set; }
        public string cop { get; set; }
        public string type { get; set; }
        public string clientId { get; set; }
        public string gradeSid { get; set; }
        public string notused { get; set; }
        public string setDate { get; set; }
        public string setMan { get; set; }
        public string remark { get; set; }
        public string unitName { get; set; }
        /// <summary>
        /// 状态，页面使用
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 等级名称
        /// </summary>
        public string GradeName { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

    }
}
