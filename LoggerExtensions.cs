using System;
using System.IO;

namespace LoggerExtensions
{
    public static class LoggerClassExtensions
    {       
        public static void CreateLogMessage(this StreamWriter writer, string message, string logFileName)
        {
            string logInfo = $"\r\n[{DefineLogDateTime()}]\n";                             

            writer.Write($"{logInfo}\nLog into '{logFileName}'\n\t: {message}\n{CreateLogBorder(logInfo)}\n");
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

