using System;

namespace Logger;

class Program
{
    static void Main(string[] args)
    {
        string logFileName = "LogFile";
        string logFilePath = "usr/desktop";
        Logger<Program> logger = new Logger<Program>(logFileName, logFilePath);        
        logger.Log("Test Log", LogLevels.Warning);
    }
}

