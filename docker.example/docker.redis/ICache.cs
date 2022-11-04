using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docker.redis
{
    public interface ICache<CacheKey, Input>
    {
        bool SetCache(string key, Input input);
        string GetCache(string key);
    }
}
