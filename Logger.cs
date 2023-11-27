using System;
using System.IO;
using FountainDesign;


namespace FountainDesign
{
    internal class Logger
    {


        static internal void logEntry(string level, string message)
        {
            //TODO Move these variables to the calling class.  
            string currentDirectory = Directory.GetCurrentDirectory();
            string basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            string logPath = Path.Combine(basePath, "LogFile.txt");
            File.AppendAllLines(logPath, new string[] { message });

        }
    }


}