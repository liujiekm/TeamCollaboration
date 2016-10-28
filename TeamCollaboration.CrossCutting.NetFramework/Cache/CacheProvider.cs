//===================================================================================
// Jay@self
//===================================================================================
// 服务器端缓存操作类
//
//
//===================================================================================
// .Net Framework 4.5.2
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/28 10:58:52
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CrossCutting.NetFramework.Cache
{
    public class CacheProvider
    {
        //采用MemoryCache缓存机制
        private static ObjectCache Cache
        {
            get { return MemoryCache.Default; }
        }

        /// <summary>
        /// 获取缓存内容
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        public static object Get(String key)
        {
            return Cache.Get(key);
        }

        /// <summary>
        /// 插入缓存（永不过期）
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public static void Set(String key, object data)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = ObjectCache.InfiniteAbsoluteExpiration
            };
            Cache.Add(key, data, policy);
        }
        /// <summary>
        /// 插入缓存（指定时间过期）
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="time">过期时间</param>
        public static void Set(String key, object data, int? time = null)
        {

            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMilliseconds(time ?? Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["eHPS_Sys_SessionTime"]))
            };
            Cache.Add(key, data, policy);
        }


        /// <summary>
        /// 指定缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Exist(String key)
        {
            return Cache.Contains(key);
        }

        /// <summary>
        /// 删除指定缓存
        /// </summary>
        /// <param name="key"></param>
        public static void Delete(String key)
        {
            Cache.Remove(key);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="key"></param>
        public static void Refresh(string key)
        {
            if (Cache.Contains(key))
            {
                var cache = Cache.GetCacheItem(key);
                if (cache != null)
                {
                    var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(Convert.ToDouble(ConfigurationManager.AppSettings["eHPS_Sys_SessionTime"])) };
                    Cache.Set(cache, policy);
                }
            }
        }
    }
}
