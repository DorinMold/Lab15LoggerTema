using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab15LoggerTema
{
    class TextFileLogger : ILogger
    {
        private string PathToDir;
        public TextFileLogger(string pathToDir = null)
        {
            if (string.IsNullOrWhiteSpace(pathToDir) || (!Directory.Exists(pathToDir)))
            {
                pathToDir = Path.GetTempPath();
            }

            this.PathToDir = pathToDir;
        }
        public void WriteLog(EnumLogLevel level, string mesajEroare, string infoSuplimentare = null)
        {
            DateTime nowDate = DateTime.Now;
            string fileName = $"err{nowDate.Year}{nowDate.Month.ToString().PadLeft(2, '0')}{nowDate.Day.ToString().PadLeft(2, '0')}.txt";
            string fullPath = Path.Combine(this.PathToDir, fileName);

            using (StreamWriter sw = File.AppendText(fullPath))
            {
                StringBuilder errorLogEntry = new StringBuilder();
                errorLogEntry.AppendLine($"{level}: {mesajEroare}");

                if (!string.IsNullOrWhiteSpace(infoSuplimentare))
                {
                    errorLogEntry.AppendLine(infoSuplimentare);
                }

                sw.WriteLine(errorLogEntry.ToString());
            }
        }
    }
}
