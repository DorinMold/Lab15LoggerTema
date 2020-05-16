using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15LoggerTema
{
    class WindowLogger : ILogger
    {
        public void WriteLog(EnumLogLevel level, string mesajEroare, string infoSuplimentare = null)
        {
            System.Diagnostics.Debug.WriteLine($"{level}: {mesajEroare}");

            if (!string.IsNullOrWhiteSpace(mesajEroare))
            {
                System.Diagnostics.Debug.WriteLine(mesajEroare);
            }
        }
    }
}
