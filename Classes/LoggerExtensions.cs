using System;
using System.IO;

namespace Logger
{
    public static class LoggerClassExtension
    {
        public static void CreateLogMessage(this StreamWriter writer, string message, LogLevels logLevel, Exception exception = null)
        {
            string logInfo = $"{DefineLogDateTime()}|";          

            writer.Write($"{logInfo}|{logLevel}|{message}|\n\t: {exception}\n");
        }

        private static string DefineLogDateTime()
        {                        
            return $"{DateTime.Now.ToShortDateString()}\n{DateTime.Now.ToLongTimeString()}";
        }     
    }
}

