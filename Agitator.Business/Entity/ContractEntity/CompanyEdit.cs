using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 修改企业单位实体类【也做接口参数使用，属性需匹配接口参数】
    /// </summary>
    public class CompanyEdit: Entity
    {
        public int id { get; set; }
        /// <summary>
        /// 单位编号
        /// </summary>
        public string unitId { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string unitName { get; set; }
        /// <summary>
        /// 企业地址
        /// </summary>
        public string address { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string linkman { get; set; }
        public string fax { get; set; }
        /// <summary>
        /// 单位法人
        /// </summary>
        public string cop { get; set; }
        /// <summary>
        /// 单位类型
        /// </summary>
        public string typeId { get; set; }
        /// <summary>
        /// 客户代码
        /// </summary>
        public string clientId { get; set; }
        /// <summary>
        /// 客户等级
        /// </summary>
        public string gradeSid { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public string notused { get; set; }
        public string setMan { get; set; }
        public string setDate { get; set; }
        public string remark { get; set; }
    }
}
