using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Entity.SystemEntity
{
    /// <summary>
    /// 系统功能板块类
    /// </summary>
    public class Menu
    {
        public int id { get; set; }
        public string loginName { get; set; }
        public string functionName { get; set; }
        public int LoginId { get; set; }
        public int functionId { get; set; }
        public int parentId { get; set; }
        public bool isModelCategory { get; set; }
        public bool isModelEntry { get; set; }
        public int sort { get; set; }
        public string url { get; set; }
        public string icon { get; set; }
    }
}
