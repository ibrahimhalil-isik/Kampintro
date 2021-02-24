using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            İbrahim sahıs1 = new İbrahim();
            sahıs1.isim = "ibrahim";
            sahıs1.boy = 197;
            sahıs1.kilo = 100;
            sahıs1.yaş = 20;

            İbrahim sahıs2 = new İbrahim();
            sahıs2.isim = "abdurrahman";
                sahıs2.boy = 150;
            sahıs2.kilo = 60;
            sahıs2.yaş = 10;

            İbrahim sahıs3 = new İbrahim();
            sahıs3.isim = "ruveyde";
            sahıs3.boy = 160;
            sahıs3.kilo = 60;
            sahıs3.yaş = 13;

            İbrahim[] sahıslar = new İbrahim[] { sahıs1, sahıs2 , sahıs3};
            foreach (var sahıs in sahıslar)
            {
                Console.WriteLine( sahıs.isim + " : " + sahıs.boy + " , "
                    + sahıs.kilo + " , " + sahıs.yaş );
            }



        }

        class İbrahim
        {
            public string isim { get; set; }
            public int boy { get; set; }
            public int kilo { get; set; }
            public int yaş { get; set; }


        }

    }
}
