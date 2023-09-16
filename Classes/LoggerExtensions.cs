using System;
using System.IO;
using Logger;

namespace LoggerExtensions
{
    public static class LoggerClassExtensions
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

