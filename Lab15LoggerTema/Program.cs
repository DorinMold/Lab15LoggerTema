using System;

namespace Lab15LoggerTema
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 0;

            ILogger LUnu = new ApLogger(new ConsoleLogger());
            ILogger LDoi = new ApLogger(new TextFileLogger(@"F:"));
            ILogger LTrei = new ApLogger(new WindowLogger());

            try
            {
                int rezultat = i / j;
            } catch (Exception e)
            {
                LUnu.WriteLog(EnumLogLevel.Avertizare, e.Message, e.StackTrace);
                LDoi.WriteLog(EnumLogLevel.RiscInalt, e.Message);
                LTrei.WriteLog(EnumLogLevel.RiscCritic, e.Message, e.StackTrace);
            }
        }
    }
}
