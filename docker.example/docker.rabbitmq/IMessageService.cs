using System;
using System.Collections.Generic;
using System.Text;

namespace docker.rabbitmq
{
    public interface IMessageService
    {
        bool PublishMessage(string message);
    }
}
