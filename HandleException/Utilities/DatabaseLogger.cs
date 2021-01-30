using System;

namespace HandleException
{
    public class DatabaseLogger:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database Logged !");
        }
    }
}