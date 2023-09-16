using System;

namespace Logger
{
    public interface LogBase
    {
        public void Log(string message, LogLevels logLevels, Exception exception = null);
        public void LogTrace(string message);
        public void LogInfo(string message);
        public void LogWarn(string message);
        public void LogError(string message, Exception exception);
        public void LogCrit(string message, Exception exception);
    }
}

