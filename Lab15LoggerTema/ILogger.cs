using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15LoggerTema
{
    interface ILogger
    {
        public void WriteLog(EnumLogLevel level, string mesajEroare, string infoSuplimentare = null);
    }
}
