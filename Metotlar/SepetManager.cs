using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {  // name convention - isimleme kuralı 
        // syntax yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi    :  " + urun.Adi + "  " + urun.Fiyati + 
                 "  " + urun.Aciklama);
        }

        public void Ekle2( string urunAdi, double fiyat, string acıklama )
        {
            Console.WriteLine("Sepete Eklendi    :  " + urunAdi + "  " + fiyat + "  " + acıklama);
        }

       
    }
        } 
