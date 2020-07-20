using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotNetCoreStrategyDesignPattern
{
    public interface IMessageProvider
    {
        void SendMessage(string message);
    }
}
