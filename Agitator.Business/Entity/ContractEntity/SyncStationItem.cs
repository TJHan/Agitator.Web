using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.ContractEntity
{
    /// <summary>
    /// 设置的单位同步站点数据集合
    /// </summary>
    public class SyncStationList
    {
        public int total { get; set; }

        public SyncStationItem[] rows { get; set; }
    }

    public class SyncStationItem
    {
        public int id { get; set; }
        public int unitId { get; set; }
        public string unitNumber { get; set; }
        public string unitName { get; set; }
        public string unitNumberOnSite { get; set; }
        public string siteName { get; set; }
        public string operationType { get; set; }

        public string operationStatus { get; set; }

        public string operationDate { get; set; }

        public string syncState { get; set; }

        public string siteAddress { get; set; }

        public string siteDirector { get; set; }

        public string siteTel { get; set; }

        public string siteEnable { get; set; }

        public string siteNetWorkStatus { get; set; }
    }
}
