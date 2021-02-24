using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Karpuz";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Diyarakır Karpuzu";

            Urun urun2 = new Urun();
            urun2.Adi = "Elma";
            urun2.Fiyati = 10 ;
            urun2.Aciklama = "Amasya Elması";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
              
            }

            Console.WriteLine( "\n\n---------Metodlar------------\n\n" );


            // instance  - örnek oluşturma

            SepetManager sepetManager = new SepetManager();

            //encaplusation - kapsülleme = Dağınık olan bir olayın belli bir düzene konulması
            // Kullanışlı ve rahat  İş daha düzenli olmuş olur
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("\n---------------------\n");

            // Kullanımı yorucu ve yanlış
            sepetManager.Ekle2("Karpuz", 80, "Diyarbakır Karpuzu");
            sepetManager.Ekle2("Elma", 10, "Amasya Elması");





        }
    }
}
