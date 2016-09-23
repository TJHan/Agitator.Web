using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agitator.Business.Entity.SystemEntity;

namespace Agitator.WebSite.Models.SystemModels
{
    public class MainPageModel
    {
        /// <summary>
        /// 登录用户的已授权版块集合
        /// </summary>
        public Menu[] MenuList { get; set; }

    }
}