using System;
using System.IO;
using System.Threading.Tasks;

namespace EasyLogPackage
{
    public class Logf<T>
    {        
        private readonly string logFilePath;
        private readonly string? nameSpace;
        private readonly WriteToFile fileService;        

        public Logf(string logFileName = "Logs.txt", string customDirectory = null)
        {
            string currentDirectory = string.IsNullOrWhiteSpace(customDirectory) ?
                Directory.GetCurrentDirectory() : customDirectory;
            
            logFilePath = Path.Combine(currentDirectory, logFileName);
            fileService = new WriteToFile();
            nameSpace = typeof(T).FullName;
        }        

        public string SetDirectory(string currentDirectory )
        {
            return currentDirectory;
        }
        
        public async Task Log(LogLevels logLevel, string message = null, Exception exception = null, int logId = 0)
        {
            switch (logLevel)
            {
                case LogLevels.Critical:
                    await LogCrit(exception, message, logId);
                    break;
                case LogLevels.Error:
                    await LogError(exception, message, logId);
                    break;
                case LogLevels.Information:
                    await LogInfo(message, logId);
                    break;
                case LogLevels.Trace:
                    await LogTrace(message, logId);
                    break;
                case LogLevels.Debug:
                    await Debug(message, logId);
                    break;
                case LogLevels.Warning:
                    await LogWarn(message, logId);
                    break;
            }
        }

        public async Task LogCrit(Exception exception, string message = null, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Critical, exception, logId);
        }

        public async Task LogError(Exception exception, string message = null, int logId = 0)
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

        public async Task Debug(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Debug, null, logId);
        }

        public async Task LogWarn(string message, int logId = 0)
        {
            await fileService.Write(logFilePath, nameSpace, message, LogLevels.Warning, null, logId);
        }

        public void Cleanf()
        {
            File.WriteAllText(logFilePath, string.Empty);
        }
    }
}
