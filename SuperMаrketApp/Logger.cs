using SuperMаrketApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMаrketApp
{
    class Logger : ILogger
    {
        public string CreateLogger(Exception ex)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("-----------------");
            builder.AppendLine(DateTime.UtcNow.ToString());
            builder.AppendLine(ex.Message);
            builder.AppendLine(ex.Source);
            builder.AppendLine(ex.StackTrace);
            return builder.ToString();
        }

        public void Log(string source)
        {
            string path = Directory.GetCurrentDirectory();
            path = Path.Combine(new string[] { path, "Log" });
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(new string[] { path, "log.txt" });
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.AppendAllText(path, source);
        }
    }
}
