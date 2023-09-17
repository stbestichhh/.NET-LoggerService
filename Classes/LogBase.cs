using System;
using System.Threading.Tasks;

namespace Logger
{
    public interface LogBase
    {
        public Task Log(string message, LogLevels logLevels, Exception exception = null);
        public Task LogTrace(string message);
        public Task LogInfo(string message);
        public Task LogWarn(string message);
        public Task LogError(string message, Exception exception);
        public Task LogCrit(string message, Exception exception);
    }
}

