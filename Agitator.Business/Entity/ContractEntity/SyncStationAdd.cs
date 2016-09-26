using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 新建设置单位到指定站点记录类
    /// </summary>
    public class SyncStationAdd : Entity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 单位主键ID
        /// </summary>
        public int unitId { get; set; }

        /// <summary>
        /// 站点主键ID
        /// </summary>
        public int siteId { get; set; }

        /// <summary>
        /// 指定单位在指定站点上的ID
        /// </summary>
        public string siteUnitId { get; set; }

        /// <summary>
        /// 操作类型，1:新增指派；2：删除指派；3：数据更新
        /// </summary>
        public string operationType { get; set; }

        /// <summary>
        /// 操作状态
        /// </summary>
        public string operationStatus { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public string operationDate { get; set; }

        /// <summary>
        /// 是否启用同步；1：开启；2：关闭
        /// </summary>
        public string syncState { get; set; }
    }
}
