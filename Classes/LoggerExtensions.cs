using System;
using System.IO;

namespace Logger
{
    static class LoggerClassExtensions
    {
        public static void CreateLogMessage(this StreamWriter writer, string nameSpace, string message, LogLevels logLevel, Exception exception = null, int logId = 0)
        {
            string logInfo = $"{DefineLogDateTime()}";

            writer.Write($"\r\n{logInfo}|{logId}|{nameSpace}|{logLevel}|{message} : {exception}\n");
        }

        private static string DefineLogDateTime()
        {
            return $"{DateTime.Now.ToShortDateString()}\n{DateTime.Now.ToShortTimeString()}";
        }
    }
}
