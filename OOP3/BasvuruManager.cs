using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        // Bir tek kredinin hesabını yapıyoruz
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //...
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        // Birden fazla kredi hesabı yapabiliriz
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
