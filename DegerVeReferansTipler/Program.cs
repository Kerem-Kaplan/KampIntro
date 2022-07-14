using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 değeri 30 olur


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;


            //sayilar1[0] değeri 999 olur
            
            //int, decimal, float, double, bool --> değer tip ==> bellekteki 'stack' alanında tutulur ve işlemler gerceklesir
            //array, class, interface --> referans tip ==> bellekteki 'heap' alanında tutulur ve işlemler gerçekleştirilir
        }
    }
}
