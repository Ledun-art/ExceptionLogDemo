using System;

namespace HandleException
{
    public class FileLogger:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File Logged!");
        }
    }
}