using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Agitator.Business.Common;
using Rock.Logging;
using Agitator.Business.Entity;
using System.Reflection;

namespace Agitator.Business.HttpHandler
{
    public class CallAPIHelper
    {
        /// <summary>
        /// API基url
        /// </summary>
        private static readonly string BaseAPIAddress = ConfigurationManager.AppSettings["zjyhj.services"];

        /// <summary>
        /// GET方式调用API方法
        /// </summary>
        /// <typeparam name="T">返回json序列化的类型</typeparam>
        /// <param name="methodAddress">调用的uri</param>
        /// <returns></returns>
        public static T CallAPIInGET<T>(string methodAddress)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.BaseAddress = BaseAPIAddress;
                    byte[] bytes = client.DownloadData(methodAddress);
                    string result = WebSiteEncodingSetting.SiteDefaultEncoding().GetString(bytes);
                    return JsonConvert.DeserializeObject<T>(result);
                }
                catch (Exception ex)
                {
                    LogHelper<CallAPIHelper>.LogException(ex);
                    return default(T);
                }
            }
        }

        /// <summary>
        /// POST方式调用API方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methodAddress"></param>
        /// <param name="nameValueCollection"></param>
        /// <returns></returns>
        public static T CallAPIInPOST<T>(string methodAddress, Dictionary<string, string> nameValueCollection)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.BaseAddress = BaseAPIAddress;
                    client.Encoding = Encoding.UTF8;
                    NameValueCollection postData = new NameValueCollection();
                    foreach (var item in nameValueCollection)
                    {
                        postData.Add(item.Key, item.Value);
                    }

                    byte[] bytes = client.UploadValues(methodAddress, "POST", postData);
                    string result = WebSiteEncodingSetting.SiteDefaultEncoding().GetString(bytes);
                    return JsonConvert.DeserializeObject<T>(result);
                }
                catch (Exception ex)
                {
                    LogHelper<CallAPIHelper>.LogException(ex);
                    return default(T);
                }
            }
        }

        /// <summary>
        /// POST方式调用API方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methodAddress"></param>
        /// <param name="entity">参数实体对象</param>
        /// <returns></returns>
        public static T CallAPIInPOST<T>(string methodAddress, Entity.Entity entity)
        {
            Type t = entity.GetType();
            PropertyInfo[] propList = t.GetProperties().Where(d => d.CanWrite).ToArray();
            Dictionary<string, string> paramsList = new Dictionary<string, string>() { };
            foreach (var item in propList)
            {
                object value = item.GetValue(entity);
                paramsList.Add(item.Name, value == null ? string.Empty : value.ToString());
            }
            return CallAPIInPOST<T>(methodAddress, paramsList);
        }
    }
}
