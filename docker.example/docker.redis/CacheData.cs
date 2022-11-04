using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docker.redis
{
    public class CacheData : ICache<string, List<string>>
    {
        RedisHelper helper;
        public CacheData()
        {
            helper = new RedisHelper();
        }
        public string GetCache(string key)
        {
            IDatabase db = helper.GetRedisConnection();
            if (db != null)
            {
                return db.StringGet(key);
            }
            return null;
        }

        public bool SetCache(string key, List<string> input)
        {
            IDatabase db = helper.GetRedisConnection();
            if (db != null)
            {
                string dataToCache = JsonConvert.SerializeObject(input);
                db.StringSet(key, dataToCache);
                //db.KeyExpire(key, DateTime.UtcNow.AddMinutes(1));
                return true;
            }
            return false;
        }
    }
}
