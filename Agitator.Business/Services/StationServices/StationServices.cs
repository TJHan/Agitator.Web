using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agitator.Business.Entity.StationEntity;
using Agitator.Business.HttpHandler;
using Agitator.Business.ParameterEntity;
using Agitator.Business.Common;

namespace Agitator.Business.Services.StationServices
{
    public class StationServices : BaseService
    {
        /// <summary>
        /// 查询站点数据集合
        /// </summary>
        /// <param name="searchEntity"></param>
        /// <returns></returns>
        public StationList GetStationList(ParamsStationSearch searchEntity)
        {
            Dictionary<string, string> paramsList = new Dictionary<string, string> { 
                {"body",searchEntity.body},
                {"siteName",searchEntity.siteName}
            };
            StationList result = CallAPIHelper.CallAPIInPOST<StationList>(APIAddressSetting.API_POST_GETSiteList, paramsList);
            return result;
        }
    }
}
