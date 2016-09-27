using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.ParameterEntity
{
    /// <summary>
    /// 已分配的站点数据查询类
    /// </summary>
    public class ParamsSyncStationSearch
    {
        public int page { get; set; }
        public int rows { get; set; }

        /// <summary>
        /// 单位主键ID
        /// </summary>
        public int unitId { get; set; }
    }
}
