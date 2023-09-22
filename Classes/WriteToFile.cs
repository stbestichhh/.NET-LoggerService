using System;
using System.IO;
using System.Threading.Tasks;

namespace Logger
{
    public class WriteToFile
    {
        public async Task Write(string logFilePath, string nameSpace, string message, LogLevels logLevel, Exception exception = null, int logId = 0)
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                await writer.CreateLogMessage(nameSpace, message, logLevel, exception, logId);
            }
        }
    }
}
