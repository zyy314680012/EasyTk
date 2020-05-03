using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTk.Helpers
{
    public static class TimeHelper
    {
        /// <summary>
        /// 当前时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetTimestamp()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds();
        }
    }
}
