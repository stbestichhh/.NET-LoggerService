using System;
using System.IO;

namespace Logger
{
    public class Logger : LogBase
    {
        private string currentDirectory;
        private string logFileName;
        private string logFilePath;
        private WriteToFile fileService;

        public Logger(string logFileName)
        {            
            currentDirectory = Directory.GetCurrentDirectory();
            this.logFileName = logFileName + ".txt";
            logFilePath = currentDirectory + "/" + this.logFileName;

            fileService = new WriteToFile();
        }

        public async Task Log(string message, LogLevels logLevel, Exception exception = null)
        {
            switch (logLevel)
            {
                case LogLevels.Critical:
                    await LogCrit(message, exception);
                    break;
                case LogLevels.Error:
                    await LogError(message, exception);
                    break;
                case LogLevels.Information:
                    await LogInfo(message);
                    break;
                case LogLevels.Trace:
                    await LogTrace(message);
                    break;
                case LogLevels.Warning:
                    await LogWarn(message);
                    break;
            }
        }

        public async Task LogCrit(string message, Exception exception)
        {
            await fileService.Write(logFilePath, message, LogLevels.Critical, exception);
        }

        public async Task LogError(string message, Exception exception)
        {
            await fileService.Write(logFilePath, message, LogLevels.Error, exception);
        }

        public async Task LogInfo(string message)
        {
            await fileService.Write(logFilePath, message, LogLevels.Information);
        }

        public async Task LogTrace(string message)
        {
            await fileService.Write(logFilePath, message, LogLevels.Trace);
        }

        public async Task LogWarn(string message)
        {
            await fileService.Write(logFilePath, message, LogLevels.Warning);
        }
    }
}

