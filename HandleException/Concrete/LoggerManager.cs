namespace HandleException
{
    public class LoggerManager
    
    {
        public void DatabaseLoggerService()
        {
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log();
        }

        public void FileLoggerService()
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log();
        }
        public void SmsLoggerService()
        {
            MessageLog messageLogger = new MessageLog();
            messageLogger.Log();
        }
    }
}