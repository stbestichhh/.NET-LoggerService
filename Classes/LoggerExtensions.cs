using System;
using System.IO;
using System.Threading.Tasks;

namespace Logger
{
    static class LoggerClassExtensions
    {
        public static async Task CreateLogMessage(this StreamWriter writer, string nameSpace, string message, LogLevels logLevel, Exception exception = null, int logId = 0)
        {
            string logInfo = $"{DefineLogDateTime()}";

            await writer.Write($"\r\n{logInfo}|{logId}|{nameSpace}|{logLevel}|{message} : {exception.Message}\n");
        }

        private static string DefineLogDateTime()
        {
            return $"{DateTime.Now.ToShortDateString()}\n{DateTime.Now.ToShortTimeString()}";
        }
    }
}
