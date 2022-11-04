using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docker.redis
{
    public class RedisHelper
    {
        public IDatabase GetRedisConnection()
        {
            IConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            if (redis.IsConnected)
            {
                return redis.GetDatabase();
            }
            else
            {
                return null;
            }
        }
    }
}
