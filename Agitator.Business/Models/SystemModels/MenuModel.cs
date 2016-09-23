using Agitator.Business.Entity.SystemEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Models.SystemModels
{
    public class MenuModel
    {
        /// <summary>
        /// 登录用户的已授权版块集合
        /// </summary>
        public Menu[] MenuList { get; set; }
    }
}
