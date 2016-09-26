using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Entity.ContractEntity;
using Agitator.Business.Entity.StationEntity;

namespace Agitator.Business.Models.Contract
{
    /// <summary>
    /// 创建/修改单位页面模型类
    /// </summary>
    public class EditCompanyModel
    {
        /// <summary>
        /// 单位详情对象
        /// </summary>
        public CompanyEdit CompanyEntity { get; set; }        

        /// <summary>
        /// 已设置的单位同步站点数据集合
        /// </summary>
        public SyncStationList SyncStationEntityList { get; set; }
    }
}
