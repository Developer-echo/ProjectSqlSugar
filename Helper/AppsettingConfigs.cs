using System;
using Microsoft.Extensions.Configuration;

namespace Helper
{
    public class AppsettingConfigs
    {
        public static IConfiguration Configuration { get; set; }

        /// <summary>
        /// 获取配置内容
        /// </summary>
        /// <param name="key">写法“KeyName” or "KeyMasterName:KeyName"</param>
        /// <returns></returns>
        public static string GetAppsetting(string key)
        {
            return Configuration[key];
        }
    }
}