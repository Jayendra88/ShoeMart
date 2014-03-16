using ShoeMartBusiness.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMartBusiness.Services
{
    public class LoggerService : ILoggerService
    {
        StreamWriter streamWriter = null;
        public string LogFileName { get; private set; }
        public LoggerService(string logFileName) { this.LogFileName = logFileName; }
        public LoggerService() : this(@"d:\AppLog.log") { }

        /// <summary>
        /// open log file
        /// </summary>
        public void OpenLog()
        {
            if (!Directory.Exists(Path.GetDirectoryName(LogFileName)))
                Directory.CreateDirectory(Path.GetDirectoryName(LogFileName));

            streamWriter = new StreamWriter(File.Open(LogFileName, FileMode.Append));
            streamWriter.AutoFlush = true;
        }

        /// <summary>
        /// close the log file
        /// </summary>
        public void CloseLog()
        {
            if (streamWriter != null)
            {
                streamWriter.Close();
                streamWriter.Dispose();
                streamWriter = null;
            }
        }

        /// <summary>
        /// write log
        /// </summary>
        /// <param name="message">message to write</param>
        public void Log(string message)
        {
            OpenLog();

            if (streamWriter != null)
            {
                streamWriter.WriteLine("------------------------------------------" +
                                  "-----------------------------------------------");
                streamWriter.WriteLine(string.Format("Log Message : {0}", message));
                streamWriter.WriteLine(string.Format("Log Date    : {0:dd}/{0:MM}/{0:yyyy}", DateTime.Now));
                streamWriter.WriteLine(string.Format("Log Time    : {0:hh}:{0:mm}:{0:ss} {0:tt}", DateTime.Now));
                streamWriter.WriteLine("------------------------------------------" +
                                  "-----------------------------------------------");
                streamWriter.WriteLine();
            }
            CloseLog();
        }
    }
}
