using System;

namespace ConsoleAppDotNetCoreStrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageProviderContext messageProviderContext = new MessageProviderContext();
            messageProviderContext.SendMessage(MessageProviderType.Kafka, "message1");
        }
    }
}
