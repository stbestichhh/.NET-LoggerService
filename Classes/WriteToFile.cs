using System;
using System.IO;
using System.Threading.Tasks;

namespace Logger
{
    public class WriteToFile
    {
        public async Task Write(string logFilePath, string nameSpace, string message, LogLevels logLevel, Exception exception = null, int logId = 0)
        {
            await using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.CreateLogMessage(nameSpace, message, logLevel, exception, logId);
            }
        }
    }
}
