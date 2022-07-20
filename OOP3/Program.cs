using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyacKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService());    alternatif kullanım 

            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
