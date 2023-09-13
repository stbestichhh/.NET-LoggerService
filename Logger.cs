using System;
using System.IO;

namespace Logger
{
    public class Logger
    {
        private string currentDirectory;
        private string logFileName;
        private string logFilePath;

        public Logger(string logFileName)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            this.logFileName = logFileName + ".txt";
            logFileName = currentDirectory + "/" + this.logFileName;
        }
    }
}

