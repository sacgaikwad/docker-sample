using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace docker.rabbitmq
{
    public class Consumer
    {

        public string Read()
        {
            string message = null;
            var connection = RabbitMqConnector.GetRabbitMqInstance();
            var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "queue-direct-green",
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
            channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);



            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, args) =>
            {
                var body = args.Body;
                message = Encoding.UTF8.GetString(body.ToArray());
                channel.BasicAck(deliveryTag: args.DeliveryTag, multiple: false);
                Console.WriteLine(message);
            };
            channel.BasicConsume(queue: "queue-direct-green",
                                         autoAck: false,
                                         consumer: consumer);

            return message;
        }
    }
}
