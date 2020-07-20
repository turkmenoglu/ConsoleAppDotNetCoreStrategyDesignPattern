using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotNetCoreStrategyDesignPattern
{
    public class MessageProviderContext
    {
        private static IDictionary<MessageProviderType, IMessageProvider> messageProviders = new Dictionary<MessageProviderType, IMessageProvider>();

        static MessageProviderContext()
        {
            messageProviders.Add(MessageProviderType.Kafka, new KafkaMessageProvider());
            messageProviders.Add(MessageProviderType.RabbitMq, new RabbitMqMessageProvider());
            messageProviders.Add(MessageProviderType.Redis, new RedisMessageProvider());
        }

        public void SendMessage(MessageProviderType messageProviderType, string message)
        {
            messageProviders[messageProviderType].SendMessage(message);
        }
    }
}
