using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace docker.rabbitmq
{
    public class RabbitMqConnector
    {
        private static IConnection connection = null;
        private static Object rabbitMqObject = new Object();

        private RabbitMqConnector()
        {

        }

        public static IConnection GetRabbitMqInstance()
        {
            lock (rabbitMqObject)
            {
                if (connection == null || connection.IsOpen == false)
                {
                    var connectionFactory = new ConnectionFactory();
                    connectionFactory.HostName = "localhost";
                    connectionFactory.UserName = "myuser";
                    connectionFactory.Password = "mypassword";
                    connectionFactory.Port = 5672;
                    connection = connectionFactory.CreateConnection();
                }
            }
            return connection;
        }
    }
}
