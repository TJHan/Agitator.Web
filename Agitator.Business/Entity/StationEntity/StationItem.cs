using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.StationEntity
{
    public class StationList
    {
        public int total { get; set; }

        public StationItem[] rows { get; set; }
    }

    /// <summary>
    /// 站点集合内的站点类
    /// </summary>
    public class StationItem
    {
        public int id { get; set; }
        public string siteName { get; set; }
        public string siteAddress { get; set; }
        public string director { get; set; }
        public string siteTel { get; set; }
        public string siteEnable { get; set; }
        public string siteNetWorkStatus { get; set; }
        public string siteProductionDataSync { get; set; }
        public string sitelastDataSyncTime { get; set; }
        public string setMan { get; set; }
        public string setDate { get; set; }
        public string remark { get; set; }
    }
}
