using System;
using System.IO;
using System.Threading.Tasks;

namespace Logger
{
    public static class Logger<T>
    {
        private static string currentDirectory;
        private static string logFileName;
        private static string logFilePath;
        private static readonly string? nameSpace;
        private static WriteToFile fileService;

        static Logger()
        {
            currentDirectory = Directory.GetCurrentDirectory();
            logFileName = "Logs.txt";
            logFilePath = currentDirectory + "/" + logFileName;

            fileService = new WriteToFile();
            nameSpace = typeof(T).FullName;
        }

        public static async Task Log(string message, LogLevels logLevel, Exception exception = null, int logId = 0)
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

        public static async Task LogCrit(string message, Exception exception, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Critical, exception, logId);
        }

        public static async Task LogError(string message, Exception exception, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Error, exception, logId);
        }

        public static async Task LogInfo(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Information, null, logId);
        }

        public static async Task LogTrace(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Trace, null, logId);
        }

        public static async Task LogWarn(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Warning, null, logId);
        }

        public static void ClearLogFile()
        {
            File.WriteAllFile(logFilePath, string.Empty);
        }
    }
}
