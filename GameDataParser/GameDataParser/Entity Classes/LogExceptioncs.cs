using System;

namespace GameDataParser.Entity_Classes
{
    class LogExceptions
    {
        public DateTime DateTime { get; private set; }
        public string StackTrace { get; private set; }
        public string ExceptionMessage { get; private set; }

        public LogExceptions()
        {
        }

        public void Log(DateTime dateTime, string message, string stackTrace)
        {
            DateTime = dateTime;
            ExceptionMessage = message;
            StackTrace = stackTrace;
        }

        public override string ToString()
        {
            return $"[{DateTime}], Exception message: {ExceptionMessage}, Stack trace: {StackTrace}";
        }
    }
}
