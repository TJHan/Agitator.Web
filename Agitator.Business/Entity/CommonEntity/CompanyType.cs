using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.CommonEntity
{
    /// <summary>
    /// 企业单位类型类
    /// </summary>
    [Serializable]
    public class CompanyTypeItem
    {
        public int id { get; set; }
        public int typeId { get; set; }
        public string type { get; set; }
        public string typeBeWrite { get; set; }
    }
}
