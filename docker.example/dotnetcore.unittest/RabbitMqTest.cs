using docker.rabbitmq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnetcore.unittest
{
    [TestClass]
    public class RabbitMqTest
    {
        [TestMethod]
        public void ReadConsumer_Test()
        {
            Consumer consumer = new Consumer();
            string message = consumer.Read();
        }
    }
}
