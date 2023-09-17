using System;
using System.IO;

namespace Logger
{
    public class WriteToFile
    {        
        public async Task Write(string logFilePath, string message, LogLevels logLevel, Exception exception = null)
        {
            await using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.CreateLogMessage(message, logLevel, exception);
            }
        }
    }
}

