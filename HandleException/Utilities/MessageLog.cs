using System;

namespace HandleException
{
    public class MessageLog:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Logged !");
        }
    }
}