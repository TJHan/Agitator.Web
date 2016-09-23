using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.ParameterEntity
{
    /// <summary>
    /// 企业单位查询条件类
    /// </summary>
    public class ParamsCompanySearch
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页数据条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 单位编号
        /// </summary>
        public string UnitId { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string linkman { get; set; }
    }
}
