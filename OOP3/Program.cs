using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {new DatabaseLoggerService(), new FileLoggerService()};
        
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,loggers);


           // Alt satırdaki yukardaki instence yapılabiilir alt satırdaki alternatif yol
           //basvuruManager.BasvuruYap(new EsnafKredisiManager(),
                    //new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() } );

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }

    }
}
