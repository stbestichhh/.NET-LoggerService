using System;
using System.IO;

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

        private string DefineLogDateTime()
        {
            return $"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}";
        }        

        public override void Log(string message)
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.Write($"\r\n{currentDirectory} | Log into : {logFileName}| {DefineLogDateTime()}");
                writer.WriteLine($"\t: {message}");
                writer.WriteLine();
            }
        }
    }
}

