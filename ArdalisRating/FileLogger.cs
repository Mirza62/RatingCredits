using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var stream = File.AppendText("log.txt"))
            {
                stream.WriteLine(message);
                stream.Flush();
            }
        }
    }
}