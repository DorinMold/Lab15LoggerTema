using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15LoggerTema
{
    class ConsoleLogger : ILogger
    {
        public void WriteLog(EnumLogLevel level, string mesajEroare, string infoSuplimentare)
        {
            Console.WriteLine($"Eroare de gravitate ( { level } ): { mesajEroare }");
            Console.WriteLine($"{ infoSuplimentare ?? "Fara informatii suplimentare" }");
        }
    }
}
