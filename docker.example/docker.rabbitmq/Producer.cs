using RabbitMQ.Client;
using System;
using System.Text;

namespace docker.rabbitmq
{
    public class Producer 
    {
        public bool PublishMessage(string message)
        {
            using (IConnection connectionFactory = RabbitMqConnector.GetRabbitMqInstance())
            {
                using (var channel = connectionFactory.CreateModel())
                {
                    channel.QueueDeclare(queue: "queue-direct-green",
                                         durable: true,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "exchange-direct",
                                         routingKey: "colour",
                                         basicProperties: null,
                                         body: body);
                }
            }
            return true;
        }
    }
}
