using System;
using System.IO;
using LoggerExtensions;

namespace Logger
{
    public class WriteToFile
    {        
        public void Write(string logFilePath, string message, LogLevels logLevel, Exception exception = null)
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.CreateLogMessage(message, logLevel, exception);
            }
        }
    }
}

