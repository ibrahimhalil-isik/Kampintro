using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"ibrahim","halil","ışık" };


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Mühendis");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
