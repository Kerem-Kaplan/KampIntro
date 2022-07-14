using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım gleiştirici yetiştirme kampı";
            string kurs2 = "Programlamaya baslangıc için temel kurs";
            string kurs3 = "Java";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım gleiştirici yetiştirme kampı",
            "Programlamaya baslangıc için temel kurs" , "Java" , "C#","C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
