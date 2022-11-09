using docker.rabbitmq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace dotnetcore.unittest
{
    [TestClass]
    public class RabbitMqTest
    {
        [TestMethod]
        public void ReadConsumer_Test()
        {

            Producer producer = new Producer();
            producer.PublishMessage("testing");


            Consumer consumer = new Consumer();
            string message = consumer.Read();
        }

        [TestMethod]
        public void Test()
        {
            float a = 2;
            float b = 3;
            float r = b / a;
        }
    }
}
