using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotNetCoreStrategyDesignPattern
{
    public class RabbitMqMessageProvider : IMessageProvider
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} was sent to RabbitMq.");
        }
    }
}
