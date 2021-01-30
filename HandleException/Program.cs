using System;

namespace HandleException
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exceptions exceptions = new Exceptions();
            
            //Example Log System
            LoggerManager loggerManager = new LoggerManager();
            loggerManager.DatabaseLoggerService();
            loggerManager.FileLoggerService();
            loggerManager.SmsLoggerService();
        }

        public void ExampleMethod()
        {
            int[] example = new int[4];
            Console.WriteLine(example[5]);
        }
    }
}