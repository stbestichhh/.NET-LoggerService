using System;
using System.IO;

namespace LoggerExtensions
{
    public static class LoggerClassExtensions
    {       
        public static void CreateLogMessage(this StreamWriter writer, string message, string logFileName)
        {
            string logInfo = $"\r\nLog into '{logFileName}' | {DefineLogDateTime()}";                             

            writer.Write($"{logInfo} + \n\t: {message}\n{CreateLogBorder(logInfo)}\n");
        }

        private static string DefineLogDateTime()
        {                        
            return $"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}";
        }

        private static string CreateLogBorder(string logInfo)
        {
            int borderLength = logInfo.Length;
            string logBorder = new string('-', borderLength);
            return logBorder;
        }        
    }
}

