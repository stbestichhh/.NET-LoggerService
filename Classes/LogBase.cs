using System;
using System.Threading.Tasks;

namespace Logger
{
    public interface LogBase
    {
        public Task Log(string message, LogLevels logLevels, Exception exception = null, int logId = 0);
        public Task LogTrace(string message, int logId = 0);
        public Task LogInfo(string message, int logId = 0);
        public Task LogWarn(string message, int logId = 0);
        public Task LogError(string message, Exception exception, int logId = 0);
        public Task LogCrit(string message, Exception exception, int logId = 0);
    }
}

