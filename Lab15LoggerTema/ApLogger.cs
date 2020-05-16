using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15LoggerTema
{
    class ApLogger : ILogger
    {
        private ILogger Logger;
        public ApLogger (ILogger logger)
        {
            Logger = logger;
        }
        public void WriteLog(EnumLogLevel level, string mesajEroare, string infoSuplimentare = null)
        {
            Logger.WriteLog(level, mesajEroare, infoSuplimentare);
        }
    }
}
