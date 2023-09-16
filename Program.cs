using System;

namespace Logger;

class Program
{
    static void Main(string[] args)
    {
        string logFileName = "LogFile";
        Logger logger = new Logger(logFileName);        
        logger.Log("Test Log");       
    }
}

