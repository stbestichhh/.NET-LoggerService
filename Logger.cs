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

        public Logger(string logFileName)
        {
            currentDirectory = Directory.GetCurrentDirectory();
            this.logFileName = logFileName + ".txt";
            logFilePath = currentDirectory + "/" + this.logFileName;
        }          

        public override void Log(string message)
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {                
                writer.CreateLogMessage(message, logFileName);
            }
        }
    }
}

