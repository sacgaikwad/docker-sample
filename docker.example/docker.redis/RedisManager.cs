using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docker.redis
{
    public class RedisManager
    {
        RedisHelper helper;
        public RedisManager()
        {
            helper = new RedisHelper();
        }

        public bool Add(string data,string key)
        {
            IDatabase db = helper.GetRedisConnection();
            if (db != null)
            {
                db.StringSet(key, data);
                db.KeyExpire(key, DateTime.UtcNow.AddMinutes(1));
            }
            return true;
        }
        public string Get(string key)
        {
            IDatabase db = helper.GetRedisConnection();
            if (db != null)
            {
                return db.StringGet(key);
            }
            return null;
        }
    }
}
