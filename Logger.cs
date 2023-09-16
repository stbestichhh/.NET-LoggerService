using System;
using System.IO;
using LoggerExtensions;

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

        public void Log(string message, LogLevels logLevel, Exception exception = null)
        {
            switch (logLevel)
            {
                case LogLevels.Critical:
                    LogCrit(message, exception);
                    break;
                case LogLevels.Error:
                    LogError(message, exception);
                    break;
                case LogLevels.Information:
                    LogInfo(message);
                    break;
                case LogLevels.Trace:
                    LogTrace(message);
                    break;
                case LogLevels.Warning:
                    LogWarn(message);
                    break;
            }
        }

        public void LogCrit(string message, Exception exception)
        {
            fileService.Write(logFilePath, message, LogLevels.Critical, exception);
        }

        public void LogError(string message, Exception exception)
        {
            fileService.Write(logFilePath, message, LogLevels.Error, exception);
        }

        public void LogInfo(string message)
        {
            fileService.Write(logFilePath, message, LogLevels.Information);
        }

        public void LogTrace(string message)
        {
            fileService.Write(logFilePath, message, LogLevels.Trace);
        }

        public void LogWarn(string message)
        {
            fileService.Write(logFilePath, message, LogLevels.Warning);
        }
    }
}

