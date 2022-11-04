using docker.redis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace docker.unittest
{
    [TestClass]
    public class RedisTest
    {
        RedisManager redisManager = new RedisManager();

        [TestMethod]
        public void RedisAdd()
        {
            redisManager.Add("sample", "sample");
        }

        [TestMethod]
        public void RedisGet()
        {
            string cacheData = redisManager.Get("sample");
            Assert.IsNotNull(cacheData);
            Assert.AreEqual("sample", cacheData);
        }


        [TestMethod]
        public void test()
        {
            var words = new List<string> { "sky", "bee", "forest", "new", "falcon", "rock",
        "cloud", "war", "small", "eagle", "blue", "frost", "water" };

            var found =
                from word in words
                where word.StartsWith("f") && word.EndsWith("t")
                select word;

        }
    }
}
