using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agitator.Business.Helper
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">double 型数字</param>
        /// <returns>DateTime</returns>
        public static Nullable<System.DateTime> ConvertIntDateTime(string d)
        {
            if (string.IsNullOrEmpty(d))
                return null;

            double t = Convert.ToDouble(d);
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddMilliseconds(t);
            return time;
        }

        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">double型数字</param>
        /// <param name="dateFormat">日期格式化类型</param>
        /// <returns>格式化成字符串的日期</returns>
        public static string ConvertIntToDateTimeString(string d, string dateFormat = "yyyy-MM-dd")
        {
            return ConvertIntDateTime(d).HasValue ? DateTimeHelper.ConvertIntDateTime(d).Value.ToString(dateFormat) : string.Empty;
        }

        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式,返回格式：1468482273277
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>long</returns>
        public static long ConvertDateTimeInt(System.DateTime time)
        {
            //double intResult = 0;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            //intResult = (time- startTime).TotalMilliseconds;
            long t = (time.Ticks - startTime.Ticks) / 10000;            //除10000调整为13位
            return t;
        }
    }
}
