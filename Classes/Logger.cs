using System;
using System.IO;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger<T> : ILogBase
    {
        private string currentDirectory;
        private string logFileName;
        private string logFilePath;
        private readonly string? nameSpace;
        private WriteToFile fileService;

        public Logger(string logFileName)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            this.logFileName = logFileName + ".txt";
            logFilePath = currentDirectory + "/" + this.logFileName;

            fileService = new WriteToFile();
            nameSpace = typeof(T).FullName;
        }

        public async Task Log(string message, LogLevels logLevel, Exception exception = null, int logId = 0)
        {
            switch (logLevel)
            {
                case LogLevels.Critical:
                    await LogCrit(message, exception, logId);
                    break;
                case LogLevels.Error:
                    await LogError(message, exception, logId);
                    break;
                case LogLevels.Information:
                    await LogInfo(message, logId);
                    break;
                case LogLevels.Trace:
                    await LogTrace(message, logId);
                    break;
                case LogLevels.Warning:
                    await LogWarn(message, logId);
                    break;
            }
        }

        public async Task LogCrit(string message, Exception exception, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Critical, exception, logId);
        }

        public async Task LogError(string message, Exception exception, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Error, exception, logId);
        }

        public async Task LogInfo(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Information, null, logId);
        }

        public async Task LogTrace(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Trace, null, logId);
        }

        public async Task LogWarn(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Warning, null, logId);
        }
    }
}
